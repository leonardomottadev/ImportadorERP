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
            this.header = header;
            this.data = data;
        }
    }
}
