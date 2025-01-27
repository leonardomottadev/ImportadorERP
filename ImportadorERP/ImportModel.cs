using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportadorERP
{
    public class ImportModel
    {
        string[] header = new string[0];
        string[,] data = new string[0,0];

        public ImportModel()
        {
        }

        public ImportModel(string[] header, string[,] data)
        {
            this.Header = header;
            this.Data = data;
        }

        public string[,] Data { get => data; set => data = value; }
        public string[] Header { get => header; set => header = value; }

        public int GetHeaderColumnIndex(string title)
        {
            int index = -1;
            for (int i = 0; i < Header.Length; i++)
            {
                if (Header[i] == title)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public string[] GetDataByColumnIndex(int col)
        {
            string[] newData = new string[data.GetLength(1)];

            if (col >= 0) 
            {
                for (int row = 0; row < data.GetLength(1); row++)
                {
                    newData[row] = data[col, row];
                }
            }
            return newData;
        } 
    }
}
