using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Notification
{
    public partial class Notification : Form
    {
        private readonly string REGISTER_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        private readonly string REGISTER_KEY = "QRF_Notification";

        private Timer alertTimer;
        private DateTime date;

        public Notification()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void Notification_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notify.Visible = true;
            }
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notify.Visible = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            notify.Visible = true;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Message is required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey(REGISTER_PATH, true);
                if (startsOnBoot.Checked)
                {
                    reg.SetValue(REGISTER_KEY, Application.ExecutablePath.ToString());
                }
                else
                {
                    if (reg.GetValue(REGISTER_KEY, null) != null)
                    {
                        reg.DeleteValue(REGISTER_KEY);
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("不好了！ 出错啦！\r\n" + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbEnable.Checked)
            {
                if (alertTimer == null)
                {
                    alertTimer = new Timer();
                    alertTimer.Interval = 1000;
                    alertTimer.Tick += AlertTimer_Tick;
                    alertTimer.Start();
                }

                date = DateTime.Now;
            }
            else
            {
                if (alertTimer != null)
                {
                    alertTimer.Stop();
                }
            }
            SaveConfig();

            Hide();
            notify.Visible = true;
        }

        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            if (date.Day != DateTime.Now.Day)
            {
                return;
            }

            if (timePicker.Value.TimeOfDay < DateTime.Now.TimeOfDay)
            {
                notify.ShowBalloonTip(1000, "404 友情提示", textBox1.Text, ToolTipIcon.Info);
                date = DateTime.Now.AddDays(1);
            }

        }


        private void LoadConfig()
        {
            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            if (settings["Enable"] == null)
            {
                configFile.AppSettings.Settings.Add("Enable", "true");
            }
            else
            {
                rbEnable.Checked = Boolean.Parse(settings["Enable"].Value);
                rbDisable.Checked = !rbEnable.Checked;
            }

            if (settings["StartsOnBoot"] == null)
            {
                settings.Add("StartsOnBoot", "true");
            }
            else
            {
                startsOnBoot.Checked = Boolean.Parse(settings["StartsOnBoot"].Value);
            }

            if (settings["Message"] == null || string.IsNullOrEmpty(settings["Message"].Value))
            {
                settings.Add("Message", "404 提醒你，是不是有什么事忘了做~");
                textBox1.Text = "404 提醒你，是不是有什么事忘了做~";
            }
            else
            {
                textBox1.Text = settings["Message"].Value;
            }

            if (settings["AlertTime"] == null)
            {
                settings.Add("AlertTime", DateTime.Now.ToString());
            }
            else
            {
                DateTime dateTime;
                if (DateTime.TryParse(settings["AlertTime"].Value, out dateTime))
                {
                    timePicker.Value = dateTime;
                }

            }

            configFile.Save(ConfigurationSaveMode.Modified, true);
        }


        private void SaveConfig()
        {
            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var setting = configFile.AppSettings.Settings;
            setting["Enable"].Value = rbEnable.Checked.ToString();
            setting["StartsOnBoot"].Value = startsOnBoot.Checked.ToString();
            setting["Message"].Value = textBox1.Text.Trim();
            setting["AlertTime"].Value = timePicker.Value.ToString();

            configFile.Save(ConfigurationSaveMode.Modified, true);
        }


    }
}
