using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImportadorERP
{
    public class Record
    {
        private int index;
        private int size;
        private string format;
        private string data;

        public Record(int index, int size, string format)
        {
            this.index = index;
            this.size = size;
            this.format = format;
            this.data = "";
        }

        public string Data { get => data; set => data = value; }
        public string Format { get => format; set => format = value; }
        public int Size { get => size; set => size = value; }
        public int Index { get => index; set => index = value; }
    }
}
