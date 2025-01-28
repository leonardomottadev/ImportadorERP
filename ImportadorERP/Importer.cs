using Excel = Microsoft.Office.Interop.Excel;

namespace ImportadorERP
{
    public static class Importer
    {
        public static ImportModel Import(string fileName, int maxReads = 0)
        {
            Excel.Application excelApp = new Excel.Application();
            string directory = $"{Environment.CurrentDirectory}/dados/{fileName}";
            ImportModel model = new();
            try
            {
                // Abre o arquivo Excel
                Excel.Workbook workBook = excelApp.Workbooks.Open(directory);
                Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Sheets[1]; // Primeira aba do Excel
                Excel.Range usedRange = workSheet.UsedRange; // Intervalo usado na planilha

                int totalRows = usedRange.Rows.Count; // Total de linhas na planilha
                int totalColumns = usedRange.Columns.Count; // Total de colunas na planilha

                if (maxReads > 0 && totalRows > maxReads)
                {
                    totalRows = maxReads;
                }

                string[,] data = new string[totalColumns, totalRows];
                string[] header = new string[totalColumns];

                Console.WriteLine($"Iniciando Leitura do arquivo:{directory}");

                for (int col = 1; col <= totalColumns; col++)
                {
                    Excel.Range cell = (Excel.Range)usedRange.Cells[1, col];
                    string? headerValue = cell?.Value2?.ToString();

                    if (!string.IsNullOrEmpty(headerValue))
                    {
                        header[col - 1] = headerValue;
                        Console.WriteLine($"{headerValue}");
                    }
                }

                for (int row = 2; row <= totalRows; row++)
                {
                    for (int col = 1; col <= totalColumns; col++)
                    {
                        Excel.Range cell = (Excel.Range)usedRange.Cells[row, col];
                        string? cellValue = cell?.Value2?.ToString();

                        if (!string.IsNullOrEmpty(cellValue))
                        {
                            Console.WriteLine($"Linha {row} Coluna{col}, Valor: {cellValue}");
                            data[col -1, row - 1] = cellValue;
                        }
                    }
                }

                model = new ImportModel(header, data);
                workBook.Close(false); // Não salva as alterações
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                // Libera os recursos COM
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
            return model;
        }
    }
}
