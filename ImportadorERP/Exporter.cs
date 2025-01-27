using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportadorERP
{
    public static class Exporter
    {
        public static bool? WriteTxt(string text)
        {
            try
            {
                DateTime now = DateTime.Now;
                string date = now.ToString("yyyyMMdd_HHmmss");

                string filePath = $"{Environment.CurrentDirectory}/dados/output_{date}.txt";

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.Write(text);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na escrita: " + ex.Message);
            }
            return false;
        }
    }
}
