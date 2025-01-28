namespace ImportadorERP
{
    public static class Exporter
    {
        public static bool? WriteTxt(string filename, string text)
        {
            try
            {
                DateTime now = DateTime.Now;
                string date = now.ToString("yyyyMMdd_HHmmss");

                string filePath = $"{Environment.CurrentDirectory}/dados/{filename}_output_{date}.txt";

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
