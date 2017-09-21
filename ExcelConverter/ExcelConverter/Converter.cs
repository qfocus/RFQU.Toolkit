using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonConverter
{
    public class Converter
    {
        public void Convert(string fileName, Direction direction)
        {
            Application excel = new Application();
            Workbook workbook = excel.Workbooks.Open(fileName);

            string path = Path.GetDirectoryName(fileName);

            for (int i = 1; i <= workbook.Sheets.Count; i++)
            {
                _Worksheet worksheet = workbook.Sheets[i];

                string content = analysisWorksheet(worksheet, direction);

                WriteToFile(path, worksheet.Name, content);
            }
          
        }

        private string analysisWorksheet(_Worksheet worksheet, Direction direction)
        {
            Range range = worksheet.UsedRange;

            int rowCount = range.Rows.Count;
            int columnCount = range.Columns.Count;

            List<string> names = new List<string>();
            List<Dictionary<string, object>> items = new List<Dictionary<string, object>>();

            if (direction == Direction.Row)
            {
                for (int i = 1; i <= columnCount; i++)
                {
                    string name = range.Cells[1, i].Value;

                    if (string.IsNullOrEmpty(name))
                    {
                        throw new ContentException(0, i, "Name should not be empty or null.");
                    }
                    names.Add(name);
                }
                for (int i = 2; i <= rowCount; i++)
                {
                    Dictionary<string, object> item = new Dictionary<string, object>();
                    for (int j = 0; j < names.Count; j++)
                    {
                        item.Add(names[j], range.Cells[i, j + 1].Value);
                    }
                    items.Add(item);
                }
            }
            else
            {
                for (int i = 1; i <= rowCount; i++)
                {
                    string name = range.Cells[i, 1].Value;

                    if (string.IsNullOrEmpty(name))
                    {
                        throw new ContentException(i, 0, "Name should not be empty or null.");
                    }
                    names.Add(name);
                }

                for (int i = 2; i <= columnCount; i++)
                {
                    Dictionary<string, object> item = new Dictionary<string, object>();
                    for (int j = 0; j < names.Count; j++)
                    {
                        item.Add(names[j], range.Cells[j + 1, i].Value);
                    }
                    items.Add(item);
                }
            }
            return JsonConvert.SerializeObject(items);
        }

        private void WriteToFile(string path, string name, string content)
        {
            string fileName = Path.Combine(path, name + ".json");

            using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                writer.Write(content);
            }

        }

    }
}
