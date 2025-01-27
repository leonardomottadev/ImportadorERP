using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImportadorERP
{
    public class LayoutFieldData
    {
        private string title;
        private string header;
        private int index;
        private int size;
        private string format;
        private string[] data;

        public LayoutFieldData(string title, int index, int size, string format)
        {
            this.title = title;
            this.index = index;
            this.size = size;
            this.format = format;
            this.Data = Array.Empty<string>();
        }

        public string Title { get => title; set => title = value; }
        public string Header { get => header; set => header = value; }
        public string Format { get => format; set => format = value; }
        public int Size { get => size; set => size = value; }
        public int Index { get => index; set => index = value; }
        public string[] Data { get => data; set => data = value; }
    }
}
