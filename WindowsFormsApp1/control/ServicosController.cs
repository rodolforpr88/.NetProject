using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ServicosController
    {
        Conexao conexao = new Conexao();
        //Servico servico = new Servico();

        /*
         * [ INICIO ] METODO PARA SALVAR O SERVIÇO NO BD USUARIO NORMAL
         */
        public void SalvarServico(Servico servicoParaIncluir)
        {   
            try
            {
                String dia = DateTime.Now.Day.ToString().ToUpper();
                String mes = DateTime.Now.Month.ToString().ToUpper();
                String ano = DateTime.Now.Year.ToString().ToUpper();
                String hora = DateTime.Now.Hour.ToString().ToUpper() + ":" + DateTime.Now.Minute.ToString().ToUpper();
                if (dia.Length == 1)
                {
                    dia = dia.Insert(0, "0");
                }
                MySqlConnection conn = conexao.conectarBD();
                conn.Open();
                MySqlCommand bdcommand = new MySqlCommand("INSERT INTO tb_servicos " +
                    "(nome_pet," +
                    "nome_proprietario," +
                    "valor," +
                    "forma_pagamento," +
                    "observacoes," +
                    "hora," +
                    "data_completa) VALUES (?,?,?,?,?," +
                    "'" + hora + "'," +
                    "'" + dia + "" +
                    "/" + mes + "" +
                    "/" + ano + "')", conn);
                bdcommand.Parameters.Add("@nome_pet", MySqlDbType.Text).Value = servicoParaIncluir.Nome_pet.ToUpper();
                bdcommand.Parameters.Add("@nome_proprietario", MySqlDbType.Text).Value = servicoParaIncluir.Nome_proprietario.ToUpper();
                bdcommand.Parameters.Add("@valor", MySqlDbType.Text).Value = servicoParaIncluir.Valor.ToUpper(); ;
                bdcommand.Parameters.Add("@forma_pagamento", MySqlDbType.Text).Value = servicoParaIncluir.Forma_pagamento.ToUpper();
                bdcommand.Parameters.Add("@observacoes", MySqlDbType.Text).Value = servicoParaIncluir.Observacoes.ToUpper();

                bdcommand.ExecuteNonQuery();
                MessageBox.Show("Cadastro salvo com sucesso!");
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro (SalvarServico): " + error);
            }
        }
        /*
        * ----------------------------------------------
        */

        /*
         * [ INICIO ] METODO PARA SALVAR O SERVIÇO NO BD USUARIO ADMIN
         */
        public void SalvarServicoADM(Servico servicoParaIncluir)
        {
            try
            {
                String hora = DateTime.Now.Hour.ToString();
                MySqlConnection conn = conexao.conectarBD();
                conn.Open();
                MySqlCommand bdcommand = new MySqlCommand("INSERT INTO tb_servicos " +
                    "(nome_pet," +
                    "nome_proprietario," +
                    "valor," +
                    "forma_pagamento," +
                    "observacoes," +
                    "hora," +
                    "data_completa) VALUES (?,?,?,?,?,?,?)", conn);
                bdcommand.Parameters.Add("@nome_pet", MySqlDbType.Text).Value = servicoParaIncluir.Nome_pet.ToUpper();
                bdcommand.Parameters.Add("@nome_proprietario", MySqlDbType.Text).Value = servicoParaIncluir.Nome_proprietario.ToUpper();
                bdcommand.Parameters.Add("@valor", MySqlDbType.Text).Value = servicoParaIncluir.Valor.ToUpper(); ;
                bdcommand.Parameters.Add("@forma_pagamento", MySqlDbType.Text).Value = servicoParaIncluir.Forma_pagamento.ToUpper();
                bdcommand.Parameters.Add("@observacoes", MySqlDbType.Text).Value = servicoParaIncluir.Observacoes.ToUpper();
                bdcommand.Parameters.Add("@hora", MySqlDbType.Text).Value = servicoParaIncluir.Hora.ToUpper();
                bdcommand.Parameters.Add("@data_completa", MySqlDbType.Text).Value = servicoParaIncluir.Data.ToUpper();


                bdcommand.ExecuteNonQuery();
                MessageBox.Show("Cadastro salvo com sucesso!");
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro (SalvarServicoADM): " + error);
            }
        }
        /*
        * ----------------------------------------------
        */

        /*
         * [ INICIO ] METODO PARA SALVAR O SERVIÇO NO BD IMPORT EXCEL
         */
        // Botão ainda não implementado porém código funcinoal
        public void SalvarServicoExcel(Servico servicoParaIncluir)
        {
            try
            {

                servicoParaIncluir.Data = servicoParaIncluir.Data.Replace("00:00:00", "").Replace(" ","");
                TextBox textoValor = new TextBox();
                textoValor.Text = servicoParaIncluir.Valor;
                servicoParaIncluir.Valor = Util.trocarDigitos(textoValor);

                MySqlConnection conn = conexao.conectarBD();
                conn.Open();
                MySqlCommand bdcommand = new MySqlCommand("INSERT INTO tb_servicos " +
                    "(nome_pet," +
                    "nome_proprietario," +
                    "valor," +
                    "forma_pagamento," +
                    "observacoes," +
                    "hora," +
                    "data_completa) VALUES (?,?,?,?,?,?,?)", conn);
                bdcommand.Parameters.Add("@nome_pet", MySqlDbType.Text).Value = servicoParaIncluir.Nome_pet.ToUpper();
                bdcommand.Parameters.Add("@nome_proprietario", MySqlDbType.Text).Value = servicoParaIncluir.Nome_proprietario.ToUpper();
                bdcommand.Parameters.Add("@valor", MySqlDbType.Text).Value = servicoParaIncluir.Valor.ToUpper(); ;
                bdcommand.Parameters.Add("@forma_pagamento", MySqlDbType.Text).Value = servicoParaIncluir.Forma_pagamento.ToUpper();
                bdcommand.Parameters.Add("@observacoes", MySqlDbType.Text).Value = servicoParaIncluir.Observacoes.ToUpper();
                bdcommand.Parameters.Add("@hora", MySqlDbType.Text).Value = servicoParaIncluir.Hora.ToUpper();
                bdcommand.Parameters.Add("@data_completa", MySqlDbType.Text).Value = servicoParaIncluir.Data.ToUpper();

                bdcommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro (SalvarServico): " + error);
            }
        }
        /*
        * ----------------------------------------------
        */

        /*
         * [ INICIO ] METODO PARA ALTERAR O SERVIÇO NO BD
         */
        public void AlterarServico(Servico servicoParaEditar)
        {
            try
            {
                
                String hora = DateTime.Now.Hour.ToString().ToUpper() + ":" + DateTime.Now.Minute.ToString().ToUpper();

                MySqlConnection conn = conexao.conectarBD();
                conn.Open();
                MySqlCommand bdcommand = new MySqlCommand("UPDATE tb_servicos SET " +
                    "nome_pet = '" + servicoParaEditar.Nome_pet.ToUpper() +"', "+
                    "nome_proprietario = '" + servicoParaEditar.Nome_proprietario.ToUpper() + "', "+
                    "valor = '" + servicoParaEditar.Valor.ToUpper() + "', "+
                    "forma_pagamento = '" + servicoParaEditar.Forma_pagamento.ToUpper() + "', "+
                    "observacoes = '" + servicoParaEditar.Observacoes.ToUpper() + "', "+
                    "hora = '" + hora +"', "+
                    "data_completa = '" + servicoParaEditar.Data + "' WHERE id = "+ servicoParaEditar.Id, conn);
                bdcommand.ExecuteNonQuery();
                MessageBox.Show("Alteração feita com sucesso!");
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro (AlterarServico): " + error);
            }
        }
        /*
         * ---------------------------------------------------------------
         */

        /*
        * [ INICIO ] METODO PARA DELETAR O SERVIÇO NO BD
        */
        public void deletarServico(int idParaExcluir, ListView listView)
        {
            try
            {
                MySqlConnection conn = conexao.conectarBD();
                conn.Open();
                MySqlCommand bdcommand = new MySqlCommand("DELETE FROM tb_servicos WHERE id = "+ idParaExcluir+ "",conn);

                bdcommand.ExecuteNonQuery();
                MessageBox.Show("item excluido com sucesso!");
                RelatoriosController relatoriosController = new RelatoriosController();
                relatoriosController.listarMesAtual(listView);
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro (DeletarServico): " + error);
            }
        }
        /*
        * ----------------------------------------------
        */
    
        /*
         * [ INICIO ] SELECIONA TODOS PETS E USUARIOS CONFORME USUARIO DIGITA O NOME DO PET COM FILTRO "DISTINCT"
         */
        public void nomePetTextChanged(TextBox nomePet,ListView listViewServicos, bool variacaoSZ)
        {
            String textoComS, textoComZ;
            if (nomePet.TextLength >= 1)
            {
                MySqlCommand bdcommand = new MySqlCommand();

                try
                {
                    MySqlConnection conn = conexao.conectarBD();
                    conn.Open();
                    if (nomePet.Text.ToUpper().Contains("S") || nomePet.Text.ToUpper().Contains("Z"))
                    {
                        // TROCAR OS DIGITOS DE "S" PARA "Z" E VISE VERSA CONFORME SOLICITADO PELO CLIENTE ****
                        // A PESQUISA É REALIZADA PELO REGEXP
                        String original = nomePet.Text;
                        textoComS = nomePet.Text.Replace("S", "Z").Replace("s", "Z");
                        textoComZ = nomePet.Text.Replace("Z", "S").Replace("z", "S");
                        bdcommand = new MySqlCommand("SELECT DISTINCT nome_pet,nome_proprietario FROM tb_servicos WHERE nome_pet REGEXP " +
                                "'" + nomePet.Text + "|" +
                                "" + textoComS + "|" +
                               "" + textoComZ + "'", conn);
                    }
                    else
                    {
                        bdcommand = new MySqlCommand("SELECT DISTINCT nome_pet,nome_proprietario FROM tb_servicos WHERE nome_pet LIKE '%" + nomePet.Text + "%'", conn);
                    }

                    MySqlDataReader reader;
                    reader = bdcommand.ExecuteReader();
                    listViewServicos.Items.Clear();

                    while (reader.Read())
                    {
                        listViewServicos.Items.Add(new ListViewItem(new[] { reader.GetString(0).ToString(), reader.GetString(1).ToString() }));
                    }

                    reader.Close();
                    bdcommand.Dispose();
                    conn.Close();
                    listViewServicos.Visible = true;
                    conn.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro (nomePetTextChanged): " + error);
                    listViewServicos.Visible = false;
                }
            }
            else
            {
                listViewServicos.Visible = false;
            }
        }
        /*
         * ---------------------------------------------------------------------------------
         */

        /*
         * [ INICIO ] DUPLO CLIQUE NA LISTVIEW E JOGA OS DADOS CLICADO NOS TEXTBOX's
         */
        public void duploCliqueListaServico(ListView listViewEncontrados,TextBox txtnomePet,TextBox txtnomeProprietario,TextBox txtvalor, DateTimePicker dateTimePicker) {
            String nomePet = listViewEncontrados.SelectedItems[0].SubItems[0].Text;
            String nomePro = listViewEncontrados.SelectedItems[0].SubItems[1].Text;
            if (nomePet != "" && nomePro != "")
            {
                try
                {
                    MySqlConnection conn = conexao.conectarBD();
                    conn.Open();
                    MySqlCommand bdcommand = new MySqlCommand("SELECT nome_pet,nome_proprietario, data_completa " +
                                        "FROM tb_servicos WHERE nome_pet = '" + nomePet + "' AND nome_proprietario = '" + nomePro + "'", conn);
                    MySqlDataReader reader;
                    reader = bdcommand.ExecuteReader();
                    if (reader.Read())
                    {
                        txtnomePet.Text = reader.GetString(0).ToString();
                        txtnomeProprietario.Text = reader.GetString(1).ToString();
                    }
                    reader.Close();
                    listViewEncontrados.Visible = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro (duploCliqueListaServico): " + error);
                    listViewEncontrados.Visible = false;

                }
            }
            else
            {
                MessageBox.Show("erro ao carregar dados para os campos.");
            }
        }
        /*
         * --------------------------------------------------------------------------
         */

        /*
        * [ INICIO ] METODO PARA PULAR DE TEXTBOX QND APERTAR "ENTER"
        */
        public void pulaProxCampo(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }
        /*
         * -----------------------------------------------------------
         */



        /*
        * [ INICIO ] METODO SEPARAR OS VALORES DA DATA_COMPLETA
        */
        public void separarData(String data_completaDoBD, String valorParaReceberDia, String valorParaReceberMes, String valorParaReceberAno)
        {
            String[] valores = data_completaDoBD.Split('/');
            valorParaReceberDia = valores[0];
            valorParaReceberMes = valores[1];
            valorParaReceberAno = valores[2];
        }
        /*
        * -----------------------------------------------------
        */

    }

}
