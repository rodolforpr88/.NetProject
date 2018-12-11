using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class RelatoriosController
    {
        Conexao conexao = new Conexao();
        /* 
         * [INICIO] BOTÃO RELATORIO MENSAL
         */
        public void selecionarPorMes(ListView listView, ComboBox comboBoxMes, ComboBox comboBoxAno)
        {
            
            try
            {
                
                MySqlConnection conn = conexao.conectarBD();
                
                if (!conn.Ping())
                {
                    conn.Open();
                }

                MySqlCommand bdcommand = new MySqlCommand("SELECT * FROM tb_servicos WHERE data_completa LIKE '%" + comboBoxMes.Text + "/" + comboBoxAno.Text + "' ORDER BY data_completa DESC", conn);
                MySqlDataReader reader;
                reader = bdcommand.ExecuteReader();
                listView.Items.Clear();
                while (reader.Read())
                {
                    listView.Items.Add(new ListViewItem(new[] {
                        reader.GetInt32(0).ToString(), // id
                        reader.GetString(7).ToString(), // data_completa
                        reader.GetString(1).ToString(), // nome_pet
                        reader.GetString(2).ToString(), // nome_proprietario
                        reader.GetString(3).ToString(), // valor
                        reader.GetString(4).ToString(), // forma_pagamento
                        reader.GetString(5).ToString(),  // observacoes
                        reader.GetString(6).ToString() // hora
                }));
                }
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro (RelatoriosController): " + error);
            }
            
        }
        /* 
         * [FIM] --------------------------------------
         */

        /* 
         * [INICIO] BOTÃO RELATORIO ANUAL
         */
        public void selecionarPorAno(ListView listView, ComboBox comboBoxAno)
        {

            if (comboBoxAno.Text != "selecione" || comboBoxAno.Text != "")
            {
                try
                {
                    MySqlConnection conn = conexao.conectarBD();
                    if (!conn.Ping())
                    {
                        conn.Open();
                    }

                    MySqlCommand bdcommand = new MySqlCommand("SELECT * FROM tb_servicos WHERE data_completa LIKE '%/%/"+comboBoxAno.Text+ "' ORDER BY SUBSTR(data_completa, 6, 4) DESC, SUBSTR( data_completa, 4, 2) DESC, SUBSTR( data_completa, 1, 2) DESC", conn);
                    MySqlDataReader reader;
                    reader = bdcommand.ExecuteReader();
                    listView.Items.Clear();
                    while (reader.Read())
                    {
                        listView.Items.Add(new ListViewItem(new[] {
                            reader.GetInt32(0).ToString(), // id
                            reader.GetString(7).ToString(), // data_completa
                            reader.GetString(1).ToString(), // nome_pet
                            reader.GetString(2).ToString(), // nome_proprietario
                            reader.GetString(3).ToString(), // valor
                            reader.GetString(4).ToString(), // forma_pagamento
                            reader.GetString(5).ToString(),  // observacoes
                            reader.GetString(6).ToString() // hora
                        }));
                    }
                    conn.Close();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro (RelatoriosController): " + error);
                }
            }
        }
        /* 
        * [FIM] -------------------------------------
        */

        /*
        * [INICIO] INICIA ATUALIZA E/OU MOSTRA SERVIÇOS DO MES ATUAL
        */
        public void listarMesAtual(ListView listView)
        {

            String mes = DateTime.Now.Month.ToString().ToUpper();
            String ano = DateTime.Now.Year.ToString().ToUpper();
            String data = mes + "/" + ano;

            try
            {
                MySqlConnection conn = conexao.conectarBD();
                if (!conn.Ping())
                {
                    conn.Open();
                }

                MySqlCommand bdcommand = new MySqlCommand("SELECT * FROM tb_servicos WHERE data_completa LIKE '%/" + data + "' ORDER BY data_completa DESC", conn);
                MySqlDataReader reader;
                reader = bdcommand.ExecuteReader();
                listView.Items.Clear();
                while (reader.Read())
                {
                    listView.Items.Add(new ListViewItem(new[] {
                        reader.GetString(0).ToString(), // id
                        reader.GetString(7).ToString(), // data_completa
                        reader.GetString(1).ToString(), // nome_pet
                        reader.GetString(2).ToString(), // nome_proprietario
                        reader.GetString(3).ToString(), // valor
                        reader.GetString(4).ToString(), // forma_pagamento
                        reader.GetString(5).ToString()  // observacoes
                }));
                }
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro (RelatoriosController): " + error);
            }
        }
        /* 
         * [FIM] --------------------------------------------------
         */

        /* 
         * [INICIO] BOTÃO RELATORIO TOTAL
         */
        public void selectRelatoriosCompleto(ListView listView)
        {

            try
            {
                MySqlConnection conn = conexao.conectarBD();
                if (!conn.Ping())
                {
                    conn.Open();
                }
                //MySqlCommand bdcommand = new MySqlCommand("SELECT * FROM tb_servicos WHERE data_completa LIKE '%/'ORDER BY data_completa DESC", conn);
                //Basicamente, estamos dizendo via ORDER BY: "ordene por Ano, depois pelo Mês, e por fim pelo Dia".
                //SUBSTR(string, inicio, qtd) extrai o pedaço da string começando por "inicio" e pegando "qtd" caracteres.

                MySqlCommand bdcommand = new MySqlCommand("SELECT * FROM tb_servicos ORDER BY SUBSTR(data_completa, 6, 4) DESC, SUBSTR( data_completa, 4, 2) DESC, SUBSTR( data_completa, 1, 2) DESC ", conn);
                //MySqlCommand bdcommand = new MySqlCommand("SELECT * FROM tb_servicos ORDER BY data_completa DESC ", conn);
                MySqlDataReader reader;
                reader = bdcommand.ExecuteReader(); 
                listView.Items.Clear();
                while (reader.Read())
                {
                    listView.Items.Add(new ListViewItem(new[] {
                        reader.GetInt32(0).ToString(), // id
                        reader.GetString(7).ToString(), // data_completa
                        reader.GetString(1).ToString(), // nome_pet
                        reader.GetString(2).ToString(), // nome_proprietario
                        reader.GetString(3).ToString(), // valor
                        reader.GetString(4).ToString(), // forma_pagamento
                        reader.GetString(5).ToString(),  // observacoes
                        //reader.GetString(6).ToString() // hora
                        
                    }));
                }
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro (RelatoriosController): " + error);
            }
        }
        /* 
         * [FIM] ---------------------------------
         */

        /* 
         * [INICIO] FILTRO QUE GERA RELATORIO %TEXTO% COM EXCESSÃO APENAS DO ID
        */
        public void gerarRelatorioporTexto(ListView listView, System.Windows.Forms.TextBox textoParaPesquisa)
        {

            if (textoParaPesquisa.Text != "")
            {
                try
                {
                    MySqlConnection conn = conexao.conectarBD();
                    if (!conn.Ping())
                    {
                        conn.Open();
                    }
                    MySqlCommand bdcommand = new MySqlCommand("SELECT * FROM tb_servicos WHERE " +
                        "nome_pet LIKE '%" + textoParaPesquisa.Text.ToUpper() + "%' OR " +
                        "nome_proprietario LIKE '%" + textoParaPesquisa.Text.ToUpper() + "%' OR " +
                        "valor LIKE '%" + textoParaPesquisa.Text.ToUpper() + "%' OR " +
                        "forma_pagamento LIKE '%" + textoParaPesquisa.Text.ToUpper() + "%' OR " +
                        "data_completa LIKE '%" + textoParaPesquisa.Text.ToUpper() + "%' GROUP BY data_completa DESC", conn);
                    MySqlDataReader reader;
                    reader = bdcommand.ExecuteReader();
                    listView.Items.Clear();
                    while (reader.Read())
                    {
                        listView.Items.Add(new ListViewItem(new[] {
                        reader.GetInt32(0).ToString(), // id
                        reader.GetString(7).ToString(), // nome_pet
                        reader.GetString(1).ToString(), // nome_proprietario
                        reader.GetString(2).ToString(), // valor
                        reader.GetString(3).ToString(), // forma_pagamento
                        reader.GetString(4).ToString(),  // observacoes
                        reader.GetString(5).ToString(), // hora
                        reader.GetString(6).ToString() // data_completa
                    }));
                    }
                    conn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro (RelatoriosController): " + error);
                }
            } else
            {
                listarMesAtual(listView);
            }
        }
        /* 
         * [FIM] ----------------------------------------
         */

        /* 
        * [INICIO] FILTRO QUE GERA RELATORIO %TEXTO% COM EXCESSÃO APENAS DO ID TEXTBOX 2
       */
        public void gerarRelatorioporTextoBox2(ListView listView, System.Windows.Forms.TextBox textoParaPesquisa1, System.Windows.Forms.TextBox textoParaPesquisa2)
        {

            if (textoParaPesquisa1.Text != "" || textoParaPesquisa2.Text != "")
            {
                try
                {
                    MySqlConnection conn = conexao.conectarBD();
                    if (!conn.Ping())
                    {
                        conn.Open();
                    }
                    MySqlCommand bdcommand = new MySqlCommand("SELECT * FROM tb_servicos WHERE " +
                        "nome_pet LIKE '%" + textoParaPesquisa1.Text.ToUpper() + "%' OR " +
                        "nome_pet LIKE '%" + textoParaPesquisa2.Text.ToUpper() + "%' OR " +
                        "nome_proprietario LIKE '%" + textoParaPesquisa1.Text.ToUpper() + "%' OR " +
                        "nome_proprietario LIKE '%" + textoParaPesquisa2.Text.ToUpper() + "%' OR " +
                        "valor LIKE '%" + textoParaPesquisa1.Text.ToUpper() + "%' OR " +
                        "valor LIKE '%" + textoParaPesquisa2.Text.ToUpper() + "%' OR " +
                        "forma_pagamento LIKE '%" + textoParaPesquisa1.Text.ToUpper() + "%' OR " +
                        "forma_pagamento LIKE '%" + textoParaPesquisa2.Text.ToUpper() + "%' OR " +
                        "data_completa LIKE '%" + textoParaPesquisa1.Text.ToUpper() + "%' OR " +
                        "data_completa LIKE '%" + textoParaPesquisa2.Text.ToUpper() + "%' GROUP BY id", conn);
                    MySqlDataReader reader;
                    reader = bdcommand.ExecuteReader();
                    listView.Items.Clear();
                    while (reader.Read())
                    {
                        listView.Items.Add(new ListViewItem(new[] {
                        reader.GetInt32(0).ToString(), // id
                        reader.GetString(7).ToString(), // nome_pet
                        reader.GetString(1).ToString(), // nome_proprietario
                        reader.GetString(2).ToString(), // valor
                        reader.GetString(3).ToString(), // forma_pagamento
                        reader.GetString(4).ToString(),  // observacoes
                        reader.GetString(5).ToString(), // hora
                        reader.GetString(6).ToString() // data_completa
                    }));
                    }
                    conn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro (RelatoriosController): " + error);
                }
            }
            else
            {
                listarMesAtual(listView);
            }
        }
        /* 
         * [FIM] ----------------------------------------
         */

        /*
        * [ INICIO ] DUPLO CLIQUE NO RELATORIO PARA ALTERAR NO FORM DE SERVIÇOS
        */
        public void duploCliqueListarNoCadastrar(bool edicao, ListView listViewEncontrados, Servico servicoRecebidoParaAlterar)
        {
            edicao = true;
            String nomePet = listViewEncontrados.SelectedItems[0].SubItems[2].Text;
            String nomePro = listViewEncontrados.SelectedItems[0].SubItems[3].Text;
            String valor = listViewEncontrados.SelectedItems[0].SubItems[4].Text;
            String forma_pagamento = listViewEncontrados.SelectedItems[0].SubItems[5].Text;
            String observacoes = listViewEncontrados.SelectedItems[0].SubItems[6].Text;
            if (nomePet != "" && nomePro != "")
            {
                try
                {
                    MySqlConnection conn = conexao.conectarBD();
                    if (!conn.Ping())
                    {
                        conn.Open();
                    }
                    MySqlCommand bdcommand = new MySqlCommand("SELECT * FROM tb_servicos WHERE nome_pet = '" + nomePet + "' AND nome_proprietario = '" + nomePro + "'", conn);
                    MySqlDataReader reader;
                    reader = bdcommand.ExecuteReader();
                    if (reader.Read())
                    {
                        servicoRecebidoParaAlterar.Id = reader.GetInt32(0);
                        servicoRecebidoParaAlterar.Nome_pet = reader.GetString(1).ToString();
                        servicoRecebidoParaAlterar.Nome_proprietario = reader.GetString(2).ToString();
                        servicoRecebidoParaAlterar.Valor = reader.GetString(3).ToString();
                        servicoRecebidoParaAlterar.Forma_pagamento = reader.GetString(4).ToString();
                        servicoRecebidoParaAlterar.Observacoes = reader.GetString(5).ToString();
                        MessageBox.Show(servicoRecebidoParaAlterar.Observacoes);
                        servicoRecebidoParaAlterar.Hora = reader.GetString(6).ToString();
                        servicoRecebidoParaAlterar.Data = reader.GetString(7).ToString();
                    }
                    reader.Close();
                    listViewEncontrados.Visible = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro (RelatoriosController): " + error);
                    listViewEncontrados.Visible = false;

                }
            }
            else
            {
                MessageBox.Show("erro ao carregar dados para os campos.");
            }
        }
        /*
        * ------------------------------------------------------------------------
        */

        /*
        * [ INICIO ] ALTERAÇÃO PARA QUE OS COMBOSBOXES INICIEM SEMPRE COM O MES E ANO ATUAL
        */
        public void comboBoxesMesEAnoAtual(ComboBox comboBoxMes, ComboBox comboBoxAno)
        {
            comboBoxMes.Text = DateTime.Now.Month.ToString().ToUpper();
            comboBoxAno.Text = DateTime.Now.Year.ToString().ToUpper();
        }
        /*
        * ----------------------------------------------------------------------------------
        */
    }
}
