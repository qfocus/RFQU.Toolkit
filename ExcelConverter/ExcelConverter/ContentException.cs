using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonConverter
{
    public class ContentException : Exception
    {
        private int Row { get; }
        private int Column { get; }


        public ContentException(int row, int column, string message) : base(message)
        {
            this.Row = row;
            this.Column = column;
        }

        public string GetMessage()
        {
            return string.Format("Invalid content at row {0}, column {1}", this.Row, this.Column);
        }


    }
}
