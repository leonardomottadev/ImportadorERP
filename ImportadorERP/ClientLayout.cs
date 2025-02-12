﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportadorERP
{
    public static class ClientLayout
    {
        #region Indexes
        public const int TIPO_DE_LINHA_INDEX = 1;
        public const int COLIGADA_INDEX = 2;
        public const int CODIGO_CLIENTE_FORNECEDOR_INDEX = 7;
        public const int NOME_FANTASIA_INDEX = 32;
        public const int NOME_INDEX = 92;
        public const int CNPJ_CPF_INDEX = 152;
        public const int INSCRICAO_ESTADUAL_INDEX = 172;
        public const int CLIENTE_FORNECEDOR_INDEX = 192;
        public const int NAO_UTILIZADO_1_INDEX = 197;
        public const int NUMERO_INDEX = 237;
        public const int COMPLEMENTO_INDEX = 245;
        public const int NAO_UTILIZADO_2_INDEX = 265;
        public const int NAO_UTILIZADO_3_INDEX = 285;
        public const int ESTADO_INDEX = 317;
        public const int CEP_INDEX = 319;
        public const int TELEFONE_INDEX = 328;
        public const int NAO_UTILIZADO_4_INDEX = 343;
        public const int NUMERO_PAGAMENTO_INDEX = 383;
        public const int COMPLEMENTO_PAGAMENTO_INDEX = 391;
        public const int NAO_UTILIZADO_5_INDEX = 411;
        public const int CIDADE_DE_PAGAMENTO_INDEX = 431;
        public const int ESTADO_DE_PAGAMENTO_INDEX = 463;
        public const int CEP_DE_PAGAMENTO_INDEX = 465;
        public const int TELEFONE_DE_PAGAMENTO_INDEX = 474;
        public const int NAO_UTILIZADO_6_INDEX = 489;
        public const int NUMERO_DE_ENTREGA_INDEX = 529;
        public const int COMPLEMENTO_DE_ENTREGA_INDEX = 537;
        public const int NAO_UTILIZADO_7_INDEX = 557;
        public const int CIDADE_DE_ENTREGA_INDEX = 577;
        public const int ESTADO_DE_ENTREGA_INDEX = 609;
        public const int CEP_DE_ENTREGA_INDEX = 611;
        public const int TELEFONE_DE_ENTREGA_INDEX = 620;
        public const int FAX_INDEX = 635;
        public const int CELULAR_INDEX = 650;
        public const int EMAIL_INDEX = 665;
        public const int CONTATO_INDEX = 725;
        public const int TIPO_DE_CLIENTE_FORNECEDOR_INDEX = 765;
        public const int ATIVO_INDEX = 790;
        public const int LIMITE_DE_CREDITO_INDEX = 795;
        public const int NAO_UTILIZADO_8_INDEX = 805;
        public const int VALOR_DO_ULTIMO_LANCAMENTO_INDEX = 815;
        public const int NAO_UTILIZADO_9_INDEX = 825;
        public const int NAO_UTILIZADO_10_INDEX = 830;
        public const int NAO_UTILIZADO_11_INDEX = 840;
        public const int NAO_UTILIZADO_12_INDEX = 850;
        public const int NAO_UTILIZADO_13_INDEX = 860;
        public const int NAO_UTILIZADO_14_INDEX = 870;
        public const int CAMPO_LIVRE_INDEX = 880;
        public const int CAMPO_ALFA_1_INDEX = 920;
        public const int CAMPO_ALFA_2_INDEX = 960;
        public const int CAMPO_ALFA_3_INDEX = 1000;
        public const int VALOR_OPCIONAL_1_INDEX = 1040;
        public const int VALOR_OPCIONAL_2_INDEX = 1050;
        public const int VALOR_OPCIONAL_3_INDEX = 1060;
        public const int DADOS_OPCIONAL_1_INDEX = 1070;
        public const int DADOS_OPCIONAL_2_INDEX = 1080;
        public const int DADOS_OPCIONAL_3_INDEX = 1090;
        public const int NAO_UTILIZADO_15_INDEX = 1100;
        public const int NAO_UTILIZADO_16_INDEX = 1115;
        public const int DATA_INICIO_ATIVIDADES_INDEX = 1116;
        public const int PATRIMONIO_INDEX = 1126;
        public const int NUMERO_DE_FUNCIONARIOS_INDEX = 1136;
        public const int NAO_UTILIZADO_17_INDEX = 1146;
        public const int COLIGADA_TIPO_DE_CLIENTE_FORNECEDOR_INDEX = 1240;
        public const int FAX_DEDICADO_INDEX = 1245;
        public const int NAO_UTILIZADO_18_INDEX = 1250;
        public const int INSCRICAO_MUNICIPAL_INDEX = 1255;
        public const int PESSOA_FISICA_OU_JURIDICA_INDEX = 1275;
        public const int CONTATO_DE_PAGAMENTO_INDEX = 1276;
        public const int CONTATO_DE_ENTREGA_INDEX = 1316;
        public const int PAIS_INDEX = 1356;
        public const int PAIS_DE_PAGAMENTO_INDEX = 1376;
        public const int PAIS_DE_ENTREGA_INDEX = 1396;
        public const int FAX_DO_ENDERECO_DE_ENTREGA_INDEX = 1416;
        public const int EMAIL_DO_ENDERECO_DE_ENTREGA_INDEX = 1431;
        public const int FAX_DO_ENDERECO_DE_PAGAMENTO_INDEX = 1491;
        public const int EMAIL_DO_ENDERECO_DE_PAGAMENTO_INDEX = 1506;
        public const int CARTEIRA_DE_IDENTIDADE_INDEX = 1566;
        public const int ORGAO_EMISSOR_DE_CARTEIRA_DE_IDENTIDADE_INDEX = 1586;
        public const int ESTADO_EMISSOR_DE_CARTEIRA_DE_IDENTIDADE_INDEX = 1596;
        public const int CODIGO_DE_MUNICIPIO_INDEX = 1598;
        public const int NAO_UTILIZADO_19_INDEX = 1618;
        public const int NAO_UTILIZADO_20_INDEX = 1623;
        public const int CODIGO_DE_CARGA_INDEX = 1624;
        public const int VINCULO_EMPREGATICIO_INDEX = 1627;
        public const int VALOR_FRETE_FORNECEDOR_INDEX = 1628;
        public const int TIPO_DE_TOMADOR_INDEX = 1638;
        public const int CONTRIBUINTE_ISS_INDEX = 1643;
        public const int NUMERO_DE_DEPENDENTES_INDEX = 1648;
        public const int EMPRESA_QUE_A_PESSOA_TRABALHA_INDEX = 1658;
        public const int ESTADO_CIVIL_INDEX = 1718;
        public const int PRODUTOR_RURAL_INDEX = 1719;
        public const int INSCRICAO_NO_SUFRAMA_INDEX = 1720;
        public const int CONTRIBUINTE_ICMS_INDEX = 1734;
        public const int ORGAO_PUBLICO_INDEX = 1735;
        public const int TELEFONE_COMERCIAL_INDEX = 1740;
        public const int CAIXA_POSTAL_INDEX = 1755;
        public const int CAIXA_POSTAL_DE_PAGAMENTO_INDEX = 1765;
        public const int CAIXA_POSTAL_DE_ENTREGA_INDEX = 1775;
        public const int CATEGORIA_DO_AUTONOMO_INDEX = 1785;
        public const int CODIGO_BRASILEIRO_DE_OCUPACAO_DO_AUTONOMO_INDEX = 1790;
        public const int NUMERO_CONTRIBUINTE_INDIVIDUAL_DO_AUTONOMO_INDEX = 1800;
        public const int NAO_UTILIZADO_21_INDEX = 1811;
        public const int VALOR_OUTRAS_DEDUCOES_CALCULO_IRRF_INDEX = 1821;
        public const int CODIGO_DA_RECEITA_INDEX = 1831;
        public const int NAO_UTILIZADO_22_INDEX = 1841;
        public const int CEI_INDEX = 1842;
        public const int OPTANTE_PELO_SIMPLES_INDEX = 1862;
        public const int TIPO_DE_RUA_INDEX = 1867;
        public const int TIPO_DE_BAIRRO_INDEX = 1872;
        public const int REGIME_ISS_INDEX = 1877;
        public const int RETENCAO_ISS_INDEX = 1878;
        public const int DATA_NASCIMENTO_INDEX = 1883;
        public const int DESATIVAR_DADOS_BANCARIOS_CLI_FOR_INDEX = 1893;
        public const int INSCRICAO_ESTADUAL_ST_DO_FORNEDOR_EM_MG_INDEX = 1894;
        public const int BAIRRO_INDEX = 1914;
        public const int BAIRRO_DE_ENTREGA_INDEX = 1944;
        public const int BAIRRO_DE_PAGAMENTO_INDEX = 1974;
        public const int RAMO_DE_ATIVIDADE_INDEX = 2004;
        public const int RUA_INDEX = 2006;
        public const int RUA_DE_PAGAMENTO_INDEX = 2106;
        public const int RUA_DE_ENTREGA_INDEX = 2206;
        public const int CODIGO_PAGAMENTO_GPS_INDEX = 2306;
        public const int NACIONALIDADE_INDEX = 2311;
        public const int CODIGO_MUNICIPIO_PAGAMENTO_INDEX = 2312;
        public const int CODIGO_MUNICIPIO_ENTREGA_INDEX = 2332;
        public const int ID_DO_PAIS_INDEX = 2352;
        public const int ID_DO_PAIS_PAGAMENTO_INDEX = 2355;
        public const int ID_DO_PAIS_ENTREGA_INDEX = 2358;
        public const int TIPO_DE_RUA_PAGAMENTO_INDEX = 2361;
        public const int TIPO_DE_BAIRRO_PAGAMENTO_INDEX = 2366;
        public const int TIPO_DE_RUA_ENTREGA_INDEX = 2371;
        public const int TIPO_DE_BAIRRO_ENTREGA_INDEX = 2376;
        public const int INDICADOR_NATUREZA_RETENCAO_NA_FONTE_INDEX = 2381;
        #endregion

        #region Sizes
        public const int TIPO_DE_LINHA_TAM = 1;
        public const int COLIGADA_TAM = 5;
        public const int CODIGO_CLIENTE_FORNECEDOR_TAM = 25;
        public const int NOME_FANTASIA_TAM = 60;
        public const int NOME_TAM = 60;
        public const int CNPJ_CPF_TAM = 20;
        public const int INSCRICAO_ESTADUAL_TAM = 20;
        public const int CLIENTE_FORNECEDOR_TAM = 5;
        public const int NAO_UTILIZADO_1_TAM = 40;
        public const int NUMERO_TAM = 8;
        public const int COMPLEMENTO_TAM = 20;
        public const int NAO_UTILIZADO_2_TAM = 20;
        public const int NAO_UTILIZADO_3_TAM = 32;
        public const int ESTADO_TAM = 2;
        public const int CEP_TAM = 9;
        public const int TELEFONE_TAM = 15;
        public const int NAO_UTILIZADO_4_TAM = 40;
        public const int NUMERO_PAGAMENTO_TAM = 8;
        public const int COMPLEMENTO_PAGAMENTO_TAM = 20;
        public const int NAO_UTILIZADO_5_TAM = 20;
        public const int CIDADE_DE_PAGAMENTO_TAM = 32;
        public const int ESTADO_DE_PAGAMENTO_TAM = 2;
        public const int CEP_DE_PAGAMENTO_TAM = 9;
        public const int TELEFONE_DE_PAGAMENTO_TAM = 15;
        public const int NAO_UTILIZADO_6_TAM = 40;
        public const int NUMERO_DE_ENTREGA_TAM = 8;
        public const int COMPLEMENTO_DE_ENTREGA_TAM = 20;
        public const int NAO_UTILIZADO_7_TAM = 20;
        public const int CIDADE_DE_ENTREGA_TAM = 32;
        public const int ESTADO_DE_ENTREGA_TAM = 2;
        public const int CEP_DE_ENTREGA_TAM = 9;
        public const int TELEFONE_DE_ENTREGA_TAM = 15;
        public const int FAX_TAM = 15;
        public const int CELULAR_TAM = 15;
        public const int EMAIL_TAM = 60;
        public const int CONTATO_TAM = 40;
        public const int TIPO_DE_CLIENTE_FORNECEDOR_TAM = 25;
        public const int ATIVO_TAM = 5;
        public const int LIMITE_DE_CREDITO_TAM = 10;
        public const int NAO_UTILIZADO_8_TAM = 10;
        public const int VALOR_DO_ULTIMO_LANCAMENTO_TAM = 10;
        public const int NAO_UTILIZADO_9_TAM = 5;
        public const int NAO_UTILIZADO_10_TAM = 10;
        public const int NAO_UTILIZADO_11_TAM = 10;
        public const int NAO_UTILIZADO_12_TAM = 10;
        public const int NAO_UTILIZADO_13_TAM = 10;
        public const int NAO_UTILIZADO_14_TAM = 10;
        public const int CAMPO_LIVRE_TAM = 40;
        public const int CAMPO_ALFA_1_TAM = 40;
        public const int CAMPO_ALFA_2_TAM = 40;
        public const int CAMPO_ALFA_3_TAM = 40;
        public const int VALOR_OPCIONAL_1_TAM = 10;
        public const int VALOR_OPCIONAL_2_TAM = 10;
        public const int VALOR_OPCIONAL_3_TAM = 10;
        public const int DADOS_OPCIONAL_1_TAM = 10;
        public const int DADOS_OPCIONAL_2_TAM = 10;
        public const int DADOS_OPCIONAL_3_TAM = 10;
        public const int NAO_UTILIZADO_15_TAM = 15;
        public const int NAO_UTILIZADO_16_TAM = 1;
        public const int DATA_INICIO_ATIVIDADES_TAM = 10;
        public const int PATRIMONIO_TAM = 10;
        public const int NUMERO_DE_FUNCIONARIOS_TAM = 10;
        public const int NAO_UTILIZADO_17_TAM = 94;
        public const int COLIGADA_TIPO_DE_CLIENTE_FORNECEDOR_TAM = 5;
        public const int FAX_DEDICADO_TAM = 5;
        public const int NAO_UTILIZADO_18_TAM = 5;
        public const int INSCRICAO_MUNICIPAL_TAM = 20;
        public const int PESSOA_FISICA_OU_JURIDICA_TAM = 1;
        public const int CONTATO_DE_PAGAMENTO_TAM = 40;
        public const int CONTATO_DE_ENTREGA_TAM = 40;
        public const int PAIS_TAM = 20;
        public const int PAIS_DE_PAGAMENTO_TAM = 20;
        public const int PAIS_DE_ENTREGA_TAM = 20;
        public const int FAX_DO_ENDERECO_DE_ENTREGA_TAM = 15;
        public const int EMAIL_DO_ENDERECO_DE_ENTREGA_TAM = 60;
        public const int FAX_DO_ENDERECO_DE_PAGAMENTO_TAM = 15;
        public const int EMAIL_DO_ENDERECO_DE_PAGAMENTO_TAM = 60;
        public const int CARTEIRA_DE_IDENTIDADE_TAM = 20;
        public const int ORGAO_EMISSOR_DE_CARTEIRA_DE_IDENTIDADE_TAM = 10;
        public const int ESTADO_EMISSOR_DE_CARTEIRA_DE_IDENTIDADE_TAM = 2;
        public const int CODIGO_DE_MUNICIPIO_TAM = 20;
        public const int NAO_UTILIZADO_19_TAM = 5;
        public const int NAO_UTILIZADO_20_TAM = 1;
        public const int CODIGO_DE_CARGA_TAM = 3;
        public const int VINCULO_EMPREGATICIO_TAM = 1;
        public const int VALOR_FRETE_FORNECEDOR_TAM = 10;
        public const int TIPO_DE_TOMADOR_TAM = 5;
        public const int CONTRIBUINTE_ISS_TAM = 5;
        public const int NUMERO_DE_DEPENDENTES_TAM = 10;
        public const int EMPRESA_QUE_A_PESSOA_TRABALHA_TAM = 60;
        public const int ESTADO_CIVIL_TAM = 1;
        public const int PRODUTOR_RURAL_TAM = 1;
        public const int INSCRICAO_NO_SUFRAMA_TAM = 14;
        public const int CONTRIBUINTE_ICMS_TAM = 1;
        public const int ORGAO_PUBLICO_TAM = 5;
        public const int TELEFONE_COMERCIAL_TAM = 15;
        public const int CAIXA_POSTAL_TAM = 10;
        public const int CAIXA_POSTAL_DE_PAGAMENTO_TAM = 10;
        public const int CAIXA_POSTAL_DE_ENTREGA_TAM = 10;
        public const int CATEGORIA_DO_AUTONOMO_TAM = 5;
        public const int CODIGO_BRASILEIRO_DE_OCUPACAO_DO_AUTONOMO_TAM = 10;
        public const int NUMERO_CONTRIBUINTE_INDIVIDUAL_DO_AUTONOMO_TAM = 11;
        public const int NAO_UTILIZADO_21_TAM = 10;
        public const int VALOR_OUTRAS_DEDUCOES_CALCULO_IRRF_TAM = 10;
        public const int CODIGO_DA_RECEITA_TAM = 10;
        public const int NAO_UTILIZADO_22_TAM = 1;
        public const int CEI_TAM = 20;
        public const int OPTANTE_PELO_SIMPLES_TAM = 5;
        public const int TIPO_DE_RUA_TAM = 5;
        public const int TIPO_DE_BAIRRO_TAM = 5;
        public const int REGIME_ISS_TAM = 1;
        public const int RETENCAO_ISS_TAM = 5;
        public const int DATA_NASCIMENTO_TAM = 10;
        public const int DESATIVAR_DADOS_BANCARIOS_CLI_FOR_TAM = 1;
        public const int INSCRICAO_ESTADUAL_ST_DO_FORNEDOR_EM_MG_TAM = 20;
        public const int BAIRRO_TAM = 30;
        public const int BAIRRO_DE_ENTREGA_TAM = 30;
        public const int BAIRRO_DE_PAGAMENTO_TAM = 30;
        public const int RAMO_DE_ATIVIDADE_TAM = 2;
        public const int RUA_TAM = 100;
        public const int RUA_DE_PAGAMENTO_TAM = 100;
        public const int RUA_DE_ENTREGA_TAM = 100;
        public const int CODIGO_PAGAMENTO_GPS_TAM = 5;
        public const int NACIONALIDADE_TAM = 1;
        public const int CODIGO_MUNICIPIO_PAGAMENTO_TAM = 20;
        public const int CODIGO_MUNICIPIO_ENTREGA_TAM = 20;
        public const int ID_DO_PAIS_TAM = 3;
        public const int ID_DO_PAIS_PAGAMENTO_TAM = 3;
        public const int ID_DO_PAIS_ENTREGA_TAM = 3;
        public const int TIPO_DE_RUA_PAGAMENTO_TAM = 5;
        public const int TIPO_DE_BAIRRO_PAGAMENTO_TAM = 5;
        public const int TIPO_DE_RUA_ENTREGA_TAM = 5;
        public const int TIPO_DE_BAIRRO_ENTREGA_TAM = 5;
        public const int INDICADOR_NATUREZA_RETENCAO_NA_FONTE_TAM = 5;
        #endregion

        #region Formats
        public const string TIPO_DE_LINHA_FORMATO = "F";
        public const string COLIGADA_FORMATO = "N";
        public const string CODIGO_CLIENTE_FORNECEDOR_FORMATO = "A";
        public const string NOME_FANTASIA_FORMATO = "A";
        public const string NOME_FORMATO = "A";
        public const string CNPJ_CPF_FORMATO = "A";
        public const string INSCRICAO_ESTADUAL_FORMATO = "A";
        public const string CLIENTE_FORNECEDOR_FORMATO = "N";
        public const string NAO_UTILIZADO_1_FORMATO = "NU";
        public const string NUMERO_FORMATO = "A";
        public const string COMPLEMENTO_FORMATO = "A";
        public const string NAO_UTILIZADO_2_FORMATO = "A";
        public const string NAO_UTILIZADO_3_FORMATO = "NU";
        public const string ESTADO_FORMATO = "A";
        public const string CEP_FORMATO = "A";
        public const string TELEFONE_FORMATO = "A";
        public const string NAO_UTILIZADO_4_FORMATO = "NU";
        public const string NUMERO_PAGAMENTO_FORMATO = "A";
        public const string COMPLEMENTO_PAGAMENTO_FORMATO = "A";
        public const string NAO_UTILIZADO_5_FORMATO = "A";
        public const string CIDADE_DE_PAGAMENTO_FORMATO = "A";
        public const string ESTADO_DE_PAGAMENTO_FORMATO = "A";
        public const string CEP_DE_PAGAMENTO_FORMATO = "A";
        public const string TELEFONE_DE_PAGAMENTO_FORMATO = "A";
        public const string NAO_UTILIZADO_6_FORMATO = "NU";
        public const string NUMERO_DE_ENTREGA_FORMATO = "A";
        public const string COMPLEMENTO_DE_ENTREGA_FORMATO = "A";
        public const string NAO_UTILIZADO_7_FORMATO = "A";
        public const string CIDADE_DE_ENTREGA_FORMATO = "A";
        public const string ESTADO_DE_ENTREGA_FORMATO = "A";
        public const string CEP_DE_ENTREGA_FORMATO = "A";
        public const string TELEFONE_DE_ENTREGA_FORMATO = "A";
        public const string FAX_FORMATO = "A";
        public const string CELULAR_FORMATO = "A";
        public const string EMAIL_FORMATO = "A";
        public const string CONTATO_FORMATO = "A";
        public const string TIPO_DE_CLIENTE_FORNECEDOR_FORMATO = "A";
        public const string ATIVO_FORMATO = "N";
        public const string LIMITE_DE_CREDITO_FORMATO = "VF";
        public const string NAO_UTILIZADO_8_FORMATO = "NU";
        public const string VALOR_DO_ULTIMO_LANCAMENTO_FORMATO = "VF";
        public const string NAO_UTILIZADO_9_FORMATO = "NU";
        public const string NAO_UTILIZADO_10_FORMATO = "NU";
        public const string NAO_UTILIZADO_11_FORMATO = "NU";
        public const string NAO_UTILIZADO_12_FORMATO = "NU";
        public const string NAO_UTILIZADO_13_FORMATO = "NU";
        public const string NAO_UTILIZADO_14_FORMATO = "NU";
        public const string CAMPO_LIVRE_FORMATO = "A";
        public const string CAMPO_ALFA_1_FORMATO = "A";
        public const string CAMPO_ALFA_2_FORMATO = "A";
        public const string CAMPO_ALFA_3_FORMATO = "A";
        public const string VALOR_OPCIONAL_1_FORMATO = "VF";
        public const string VALOR_OPCIONAL_2_FORMATO = "VF";
        public const string VALOR_OPCIONAL_3_FORMATO = "VF";
        public const string DADOS_OPCIONAL_1_FORMATO = "Data";
        public const string DADOS_OPCIONAL_2_FORMATO = "Data";
        public const string DADOS_OPCIONAL_3_FORMATO = "Data";
        public const string NAO_UTILIZADO_15_FORMATO = "NU";
        public const string NAO_UTILIZADO_16_FORMATO = "NU";
        public const string DATA_INICIO_ATIVIDADES_FORMATO = "Data";
        public const string PATRIMONIO_FORMATO = "VF";
        public const string NUMERO_DE_FUNCIONARIOS_FORMATO = "N";
        public const string NAO_UTILIZADO_17_FORMATO = "NU";
        public const string COLIGADA_TIPO_DE_CLIENTE_FORNECEDOR_FORMATO = "N";
        public const string FAX_DEDICADO_FORMATO = "N";
        public const string NAO_UTILIZADO_18_FORMATO = "NU";
        public const string INSCRICAO_MUNICIPAL_FORMATO = "A";
        public const string PESSOA_FISICA_OU_JURIDICA_FORMATO = "A";
        public const string CONTATO_DE_PAGAMENTO_FORMATO = "A";
        public const string CONTATO_DE_ENTREGA_FORMATO = "A";
        public const string PAIS_FORMATO = "A";
        public const string PAIS_DE_PAGAMENTO_FORMATO = "A";
        public const string PAIS_DE_ENTREGA_FORMATO = "A";
        public const string FAX_DO_ENDERECO_DE_ENTREGA_FORMATO = "A";
        public const string EMAIL_DO_ENDERECO_DE_ENTREGA_FORMATO = "A";
        public const string FAX_DO_ENDERECO_DE_PAGAMENTO_FORMATO = "A";
        public const string EMAIL_DO_ENDERECO_DE_PAGAMENTO_FORMATO = "A";
        public const string CARTEIRA_DE_IDENTIDADE_FORMATO = "A";
        public const string ORGAO_EMISSOR_DE_CARTEIRA_DE_IDENTIDADE_FORMATO = "A";
        public const string ESTADO_EMISSOR_DE_CARTEIRA_DE_IDENTIDADE_FORMATO = "A";
        public const string CODIGO_DE_MUNICIPIO_FORMATO = "A";
        public const string NAO_UTILIZADO_19_FORMATO = "N";
        public const string NAO_UTILIZADO_20_FORMATO = "NU";
        public const string CODIGO_DE_CARGA_FORMATO = "A";
        public const string VINCULO_EMPREGATICIO_FORMATO = "A";
        public const string VALOR_FRETE_FORNECEDOR_FORMATO = "VF";
        public const string TIPO_DE_TOMADOR_FORMATO = "N";
        public const string CONTRIBUINTE_ISS_FORMATO = "N";
        public const string NUMERO_DE_DEPENDENTES_FORMATO = "N";
        public const string EMPRESA_QUE_A_PESSOA_TRABALHA_FORMATO = "A";
        public const string ESTADO_CIVIL_FORMATO = "A";
        public const string PRODUTOR_RURAL_FORMATO = "A";
        public const string INSCRICAO_NO_SUFRAMA_FORMATO = "A";
        public const string CONTRIBUINTE_ICMS_FORMATO = "N";
        public const string ORGAO_PUBLICO_FORMATO = "N";
        public const string TELEFONE_COMERCIAL_FORMATO = "A";
        public const string CAIXA_POSTAL_FORMATO = "A";
        public const string CAIXA_POSTAL_DE_PAGAMENTO_FORMATO = "A";
        public const string CAIXA_POSTAL_DE_ENTREGA_FORMATO = "A";
        public const string CATEGORIA_DO_AUTONOMO_FORMATO = "N";
        public const string CODIGO_BRASILEIRO_DE_OCUPACAO_DO_AUTONOMO_FORMATO = "A";
        public const string NUMERO_CONTRIBUINTE_INDIVIDUAL_DO_AUTONOMO_FORMATO = "A";
        public const string NAO_UTILIZADO_21_FORMATO = "NU";
        public const string VALOR_OUTRAS_DEDUCOES_CALCULO_IRRF_FORMATO = "VF";
        public const string CODIGO_DA_RECEITA_FORMATO = "A";
        public const string NAO_UTILIZADO_22_FORMATO = "NU";
        public const string CEI_FORMATO = "A";
        public const string OPTANTE_PELO_SIMPLES_FORMATO = "N";
        public const string TIPO_DE_RUA_FORMATO = "N";
        public const string TIPO_DE_BAIRRO_FORMATO = "N";
        public const string REGIME_ISS_FORMATO = "A";
        public const string RETENCAO_ISS_FORMATO = "N";
        public const string DATA_NASCIMENTO_FORMATO = "Data";
        public const string DESATIVAR_DADOS_BANCARIOS_CLI_FOR_FORMATO = "N";
        public const string INSCRICAO_ESTADUAL_ST_DO_FORNEDOR_EM_MG_FORMATO = "A";
        public const string BAIRRO_FORMATO = "A";
        public const string BAIRRO_DE_ENTREGA_FORMATO = "A";
        public const string BAIRRO_DE_PAGAMENTO_FORMATO = "A";
        public const string RAMO_DE_ATIVIDADE_FORMATO = "N";
        public const string RUA_FORMATO = "A";
        public const string RUA_DE_PAGAMENTO_FORMATO = "A";
        public const string RUA_DE_ENTREGA_FORMATO = "A";
        public const string CODIGO_PAGAMENTO_GPS_FORMATO = "A";
        public const string NACIONALIDADE_FORMATO = "N";
        public const string CODIGO_MUNICIPIO_PAGAMENTO_FORMATO = "A";
        public const string CODIGO_MUNICIPIO_ENTREGA_FORMATO = "A";
        public const string ID_DO_PAIS_FORMATO = "N";
        public const string ID_DO_PAIS_PAGAMENTO_FORMATO = "N";
        public const string ID_DO_PAIS_ENTREGA_FORMATO = "N";
        public const string TIPO_DE_RUA_PAGAMENTO_FORMATO = "N";
        public const string TIPO_DE_BAIRRO_PAGAMENTO_FORMATO = "N";
        public const string TIPO_DE_RUA_ENTREGA_FORMATO = "N";
        public const string TIPO_DE_BAIRRO_ENTREGA_FORMATO = "N";
        public const string INDICADOR_NATUREZA_RETENCAO_NA_FONTE_FORMATO = "N";
        #endregion

        public static string GetTXTData(string data, int size, string format)
        {
            string txtData = "";
            string zeroes = "";
            string emptySpaces = "";

            if (data == null)
            {
                data = "";
            }

            if(data.Length > size)
            {
                data = data.Substring(0, size);
            }

            switch (format)
            {
                // N = Campo numérico, alinhado à direita com zeros à esquerda.
                case "N":
                    if (size > data.Length) 
                    {
                        zeroes = new string('0', size - data.Length);
                    }
                    txtData = zeroes + data;
                    break;
                // A = Campo alfanumérico, alinhado à esquerda com espaços à direita.
                case "A":
                    if (size > data.Length) 
                    {
                        emptySpaces = new string(' ', size - data.Length);
                    }
                    txtData = data + emptySpaces;
                    break;
                // VF = Valor Financeiro, campo numérico, alinhado à direita com zeros à esquerda e com um ponto (.) ou vírgula (,) como separador decimal
                case "VF":
                    if (size > data.Length)
                    {
                        zeroes = new string('0', size - data.Length);
                    }
                    txtData = zeroes + data;
                    break;
                // Data = Campo alfanumérico, no formato DD/MM/AAAA ou DDMMAAAA.
                case "Data":
                    txtData = new string(' ', size);
                    //if(data == "")
                    //{
                    //    txtData = "01/01/2025";
                    //}
                    break;
                // NU = Não Utilizado, preencher com espaços.
                case "NU":
                    txtData = new string(' ', size);
                    break;
                default:
                    break;
            }
            return txtData;
        }
    }
}
