﻿namespace ImportadorERP
{
    public static class ClientTask
    {
        private static readonly string[] SEPARATOR = [" - "];
        private static readonly int MAX_ROWS_READ = 0;

        public static void Run()
        {
            Console.WriteLine("Início - Clientes");

            // Importar dados + cabeçalhos
            //ImportModel importModel = Importer.Import("relatorio_clientes.xlsx", MAX_ROWS_READ + 1);
            ImportModel importModel = Importer.Import("relatorio_clientes.xlsx", 0);

            // obter os campos do layout do cliente
            LayoutFieldData[] layouts = LayoutManager.GetCompleteClientLayout();

            // Associar títulos do layout com cabeçalhos de importação
            List<LayoutFieldData> layoutFieldDataList = layouts.Select(record => record).ToList();
            List<(string LayoutTitle, string ImportHeader)> title_header_association = new List<(string, string)>
            {
                ( "TIPO_DE_LINHA", "" ),
                ( "COLIGADA", "" ),
                ( "CODIGO_CLIENTE_FORNECEDOR", "CNPJ" ),
                ( "NOME_FANTASIA", "Nome" ),
                ( "NOME", "Nome" ),
                ( "CNPJ_CPF", "CNPJ" ),
                ( "INSCRICAO_ESTADUAL", "" ),
                ( "CLIENTE_FORNECEDOR", "" ),
                ( "NAO_UTILIZADO_1", "Endereço comercial" ),
                ( "NUMERO", "Número do endereço comercial" ),
                ( "COMPLEMENTO", "Complemento comercial" ),
                ( "NAO_UTILIZADO_2", "" ),
                ( "NAO_UTILIZADO_3", "" ),
                ( "ESTADO", "UF comercial " ),
                ( "CEP", "CEP comercial" ),
                ( "TELEFONE", "Telefone residencial" ),
                ( "NAO_UTILIZADO_4", "" ),
                ( "NUMERO_PAGAMENTO", "" ),
                ( "COMPLEMENTO_PAGAMENTO", "" ),
                ( "NAO_UTILIZADO_5", "" ),
                ( "CIDADE_DE_PAGAMENTO", "" ),
                ( "ESTADO_DE_PAGAMENTO", "" ),
                ( "CEP_DE_PAGAMENTO", "" ),
                ( "TELEFONE_DE_PAGAMENTO", "" ),
                ( "NAO_UTILIZADO_6", "" ),
                ( "NUMERO_DE_ENTREGA", "" ),
                ( "COMPLEMENTO_DE_ENTREGA", "" ),
                ( "NAO_UTILIZADO_7", "" ),
                ( "CIDADE_DE_ENTREGA", "" ),
                ( "ESTADO_DE_ENTREGA", "" ),
                ( "CEP_DE_ENTREGA", "" ),
                ( "TELEFONE_DE_ENTREGA", "" ),
                ( "FAX", "" ),
                ( "CELULAR", "" ),
                ( "EMAIL", "E-mail" ),
                ( "CONTATO", "" ),
                ( "TIPO_DE_CLIENTE", "Tipo cliente" ),
                ( "ATIVO", "" ),
                ( "LIMITE_DE_CREDITO", "" ),
                ( "NAO_UTILIZADO_8", "" ),
                ( "VALOR_DO_ULTIMO_LANCAMENTO", "" ),
                ( "NAO_UTILIZADO_9", "" ),
                ( "NAO_UTILIZADO_10", "" ),
                ( "NAO_UTILIZADO_11", "" ),
                ( "NAO_UTILIZADO_12", "" ),
                ( "NAO_UTILIZADO_13", "" ),
                ( "NAO_UTILIZADO_14", "" ),
                ( "CAMPO_LIVRE", "" ),
                ( "CAMPO_ALFA_1", "" ),
                ( "CAMPO_ALFA_2", "" ),
                ( "CAMPO_ALFA_3", "" ),
                ( "VALOR_OPCIONAL_1", "" ),
                ( "VALOR_OPCIONAL_2", "" ),
                ( "VALOR_OPCIONAL_3", "" ),
                ( "DADOS_OPCIONAL_1", "" ),
                ( "DADOS_OPCIONAL_2", "" ),
                ( "DADOS_OPCIONAL_3", "" ),
                ( "NAO_UTILIZADO_15", "" ),
                ( "NAO_UTILIZADO_16", "" ),
                ( "DATA_INICIO_ATIVIDADES", "" ),
                ( "PATRIMONIO", "" ),
                ( "NUMERO_DE_FUNCIONARIOS", "" ),
                ( "NAO_UTILIZADO_17", "" ),
                ( "COLIGADA_TIPO_DE_CLIENTE", "" ),
                ( "FAX_DEDICADO", "" ),
                ( "NAO_UTILIZADO_18", "" ),
                ( "INSCRICAO_MUNICIPAL", "" ),
                ( "PESSOA_FISICA_OU_JURIDICA", "" ),
                ( "CONTATO_DE_PAGAMENTO", "" ),
                ( "CONTATO_DE_ENTREGA", "" ),
                ( "PAIS", "" ),
                ( "PAIS_DE_PAGAMENTO", "" ),
                ( "PAIS_DE_ENTREGA", "" ),
                ( "FAX_DO_ENDERECO_DE_ENTREGA", "" ),
                ( "EMAIL_DO_ENDERECO_DE_ENTREGA", "" ),
                ( "FAX_DO_ENDERECO_DE_PAGAMENTO", "" ),
                ( "EMAIL_DO_ENDERECO_DE_PAGAMENTO", "" ),
                ( "CARTEIRA_DE_IDENTIDADE", "" ),
                ( "ORGAO_EMISSOR_DE_CARTEIRA_DE_IDENTIDADE", "" ),
                ( "ESTADO_EMISSOR_DE_CARTEIRA_DE_IDENTIDADE", "" ),
                ( "CODIGO_DE_MUNICIPIO", "" ),
                ( "NAO_UTILIZADO_19", "" ),
                ( "NAO_UTILIZADO_20", "" ),
                ( "CODIGO_DE_CARGA", "" ),
                ( "VINCULO_EMPREGATICIO", "" ),
                ( "VALOR_FRETE_FORNECEDOR", "" ),
                ( "TIPO_DE_TOMADOR", "" ),
                ( "CONTRIBUINTE_ISS", "" ),
                ( "NUMERO_DE_DEPENDENTES", "" ),
                ( "EMPRESA_QUE_A_PESSOA_TRABALHA", "" ),
                ( "ESTADO_CIVIL", "" ),
                ( "PRODUTOR_RURAL", "" ),
                ( "INSCRICAO_NO_SUFRAMA", "" ),
                ( "CONTRIBUINTE_ICMS", "" ),
                ( "CONTRIBUINTE_ICMS", "" ),
                ( "ORGAO_PUBLICO", "" ),
                ( "TELEFONE_COMERCIAL", "" ),
                ( "CAIXA_POSTAL", "" ),
                ( "CAIXA_POSTAL_DE_PAGAMENTO", "" ),
                ( "CAIXA_POSTAL_DE_ENTREGA", "" ),
                ( "CATEGORIA_DO_AUTONOMO", "" ),
                ( "CODIGO_BRASILEIRO_DE_OCUPACAO_DO_AUTONOMO", "" ),
                ( "NUMERO_CONTRIBUINTE_INDIVIDUAL_DO_AUTONOMO", "" ),
                ( "NAO_UTILIZADO_21", "" ),
                ( "VALOR_OUTRAS_DEDUCOES_CALCULO_IRRF", "" ),
                ( "CODIGO_DA_RECEITA", "" ),
                ( "NAO_UTILIZADO_22", "" ),
                ( "CEI", "" ),
                ( "OPTANTE_PELO_SIMPLES", "" ),
                ( "TIPO_DE_RUA", "Endereço comercial" ),
                ( "TIPO_DE_BAIRRO", "" ),
                ( "REGIME_ISS", "" ),
                ( "RETENCAO_ISS", "" ),
                ( "DATA_NASCIMENTO", "" ),
                ( "DESATIVAR_DADOS_BANCARIOS_CLI_FOR", "" ),
                ( "INSCRICAO_ESTADUAL_ST_DO_FORNEDOR_EM_MG", "" ),
                ( "BAIRRO", "Bairro comercial" ),
                ( "BAIRRO_DE_ENTREGA", "" ),
                ( "BAIRRO_DE_PAGAMENTO", "" ),
                ( "RAMO_DE_ATIVIDADE", "" ),
                ( "RUA", "Endereço comercial" ),
                ( "RUA_DE_PAGAMENTO", "" ),
                ( "RUA_DE_ENTREGA", "" ),
                ( "CODIGO_PAGAMENTO_GPS", "" ),
                ( "NACIONALIDADE", "" ),
                ( "CODIGO_MUNICIPIO_PAGAMENTO", "" ),
                ( "CODIGO_MUNICIPIO_ENTREGA", "" ),
                ( "ID_DO_PAIS", "" ),
                ( "ID_DO_PAIS_PAGAMENTO", "" ),
                ( "ID_DO_PAIS_ENTREGA", "" ),
                ( "TIPO_DE_RUA_PAGAMENTO", "Endereço comercial" ),
                ( "TIPO_DE_BAIRRO_PAGAMENTO", "" ),
                ( "TIPO_DE_RUA_ENTREGA", "Endereço comercial" ),
                ( "TIPO_DE_BAIRRO_ENTREGA", "" ),
                ( "INDICADOR_NATUREZA_RETENCAO_NA_FONTE", "" )
            };

            int maxDataSize = 0;

            // Salvando dados lidos para cada campo de layout
            foreach (var (LayoutTitle, ImportHeader) in title_header_association)
            {
                if (ImportHeader != null && ImportHeader.Length > 0)
                {
                    LayoutFieldData? layoutField = (layoutFieldDataList.Where(l => l.Title == LayoutTitle)).FirstOrDefault();
                    if (layoutField != null)
                    {
                        layoutField.Header = ImportHeader;
                        int columnIndex = importModel.GetHeaderColumnIndex(ImportHeader);
                        var columnData = importModel.GetDataByColumnIndex(columnIndex);

                        layoutFieldDataList.Where(l => l.Title == LayoutTitle).First().Data = columnData;
                        if (columnData.Length > maxDataSize)
                        {
                            maxDataSize = columnData.Length;
                        }
                    }
                }
            }

            Console.WriteLine("Tamanho dos dados: " + maxDataSize);

            // Percorre linhas
            string dataLine = "";
            string newData = "";
            try
            {
                for (int row = 1; row < maxDataSize; row++)
                {
                    dataLine += "C";
                    foreach (var layoutField in layoutFieldDataList)
                    {
                        newData = "";

                        if (layoutField.Title == "CLIENTE_FORNECEDOR")
                        {
                            newData = "00001";
                        }
                        else if (layoutField.Title == "TIPO_DE_CLIENTE")
                        {
                            string tipo_de_cliente = layoutField.Data[row];
                            string cliente = "00001";

                            switch (tipo_de_cliente)
                            {
                                case "Alimentício":
                                    cliente = "00028";
                                    break;
                                case "Celulose":
                                    cliente = "00029";
                                    break;
                                case "Cimenteira":
                                    cliente = "00030";
                                    break;
                                case "Energia":
                                    cliente = "00031";
                                    break;
                                case "Exploração Petróleo":
                                    cliente = "00032";
                                    break;
                                case "Mineração":
                                    cliente = "00033";
                                    break;
                                case "Naval":
                                    cliente = "00034";
                                    break;
                                case "Outros":
                                    cliente = "00035";
                                    break;
                                case "Petroquímico":
                                    cliente = "00036";
                                    break;
                                case "Portuário":
                                    cliente = "00037";
                                    break;
                                case "Prestador de serviço":
                                    cliente = "00038";
                                    break;
                                case "Quimico":
                                    cliente = "00039";
                                    break;
                                case "Químico":
                                    cliente = "00039";
                                    break;
                                case "Refino de Petróleo":
                                    cliente = "00040";
                                    break;
                                case "Siderúrgico":
                                    cliente = "00041";
                                    break;
                                case "Sucroenergético":
                                    cliente = "00042";
                                    break;
                                case "Órgão publico":
                                    cliente = "00043";
                                    break;
                                default:
                                    break;
                            }
                            newData = ClientLayout.GetTXTData(cliente, layoutField.Size, layoutField.Format);
                        }
                        else if (layoutField.Title == "PESSOA_FISICA_OU_JURIDICA")
                        {
                            newData = "J";
                        }
                        else if (layoutField.Title == "ATIVO")
                        {
                            newData = ClientLayout.GetTXTData("00001", layoutField.Size, layoutField.Format);
                        }
                        else if (layoutField.Title == "REGIME_ISS")
                        {
                            newData = ClientLayout.GetTXTData("N", layoutField.Size, layoutField.Format);
                        }
                        else if (layoutField.Title == "PAIS" || layoutField.Title == "PAIS_DE_PAGAMENTO" || layoutField.Title == "PAIS_DE_ENTREGA")
                        {
                            newData = ClientLayout.GetTXTData("Brasil", layoutField.Size, layoutField.Format);
                        }
                        else if (layoutField.Title == "ID_DO_PAIS" || layoutField.Title == "ID_DO_PAIS_PAGAMENTO" || layoutField.Title == "ID_DO_PAIS_ENTREGA")
                        {
                            newData = ClientLayout.GetTXTData("001", layoutField.Size, layoutField.Format);
                        }
                        else if (layoutField.Title == "TIPO_DE_BAIRRO" || layoutField.Title == "TIPO_DE_BAIRRO_PAGAMENTO" || layoutField.Title == "TIPO_DE_BAIRRO_ENTREGA")
                        {
                            newData = ClientLayout.GetTXTData("00001", layoutField.Size, layoutField.Format);
                        }
                        else if (layoutField.Title == "TIPO_DE_RUA" || layoutField.Title == "TIPO_DE_RUA_PAGAMENTO" || layoutField.Title == "TIPO_DE_RUA_ENTREGA")
                        {
                            string tipo_rua = "00001";
                            string tp_rua;

                            if (layoutField.Data != null && layoutField.Data.Length >= row)
                            {
                                tp_rua = layoutField.Data[row];
                                if(tp_rua == null)
                                {
                                    tp_rua = "";
                                }

                                if (tp_rua.IndexOf("alameda", StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    tipo_rua = "00004";
                                }
                                else if (tp_rua.IndexOf("avenida", StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    tipo_rua = "00006";
                                }
                                else if(tp_rua.IndexOf("rodovia", StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    tipo_rua = "00034";
                                }
                                else if(tp_rua.IndexOf("est", StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    tipo_rua = "00018";
                                }
                            }
                            newData = ClientLayout.GetTXTData(tipo_rua, layoutField.Size, layoutField.Format);
                        }
                        else if (layoutField.Data != null && layoutField.Data.Length >= row)
                        {
                            newData = ClientLayout.GetTXTData(layoutField.Data[row], layoutField.Size, layoutField.Format);
                        }
                        else
                        {
                            newData = ClientLayout.GetTXTData(System.String.Empty, layoutField.Size, layoutField.Format);
                        }
                        dataLine += newData;
                    }
                    dataLine += Environment.NewLine;
                    Console.WriteLine($"Linha importada: {row}/{maxDataSize}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            Console.WriteLine("Salvando arquivo .txt");

            // Salvar em um novo arquivo .txt
            Exporter.WriteTxt($"{MAX_ROWS_READ}_CLIENTES_IBNDT", dataLine);

            Console.WriteLine("Fim da execução - Clientes");
        }
    }
}
