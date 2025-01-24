using ImportadorERP;

Console.WriteLine("Hello, World!");

// obter o Layout
Record[] layouts = LayoutManager.GetCompleteClientLayout();

List<int> index_list = layouts.Select(layout => layout.Index).ToList();

// abrir arquivos na pasta selecionada para a importação

// realizar a leitura dos dados com base no layout 

// Converter para o layout

// Salvar em um novo arquivo .txt

Console.ReadKey();