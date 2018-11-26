using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{

    public partial class CadastrarServicoForm : Form
    {
        ServicosController servicosController = new ServicosController();
        Servico servico = new Servico();
        Usuario usuario = new Usuario();
        RelatoriosForm relatoriosForm = new RelatoriosForm();
        bool editar_servico = false;
        bool variacao = false;

        /*
        * [ INICIO ] METODO PADRÃO SEM PARAMETROS
        */
        public CadastrarServicoForm()
        {
            InitializeComponent();
        }
        /*
        * ----------------------------------------
        */

        /*
        * [ INICIO ] METODO PARA PEGAR O LOGIN E SENHA DO USUARIO DIGITADO NO LOGIN FORM
        */
        public CadastrarServicoForm(String login, String senha)
        {
            usuario.Login = login;
            usuario.Senha = senha;
            InitializeComponent();
        }
        /*
        * ------------------------------------------------------------------------------
        */

        /*
        * [ INICIO ] METODO PARA TRAZER AS INFORMAÇÕES DA TELA RELATORIOS PARA ALTERAÇÃO DE DADOS
        */
        public CadastrarServicoForm(bool editar, Servico servicoParaReceberDeRelatorio)
        {
            servico.Id = servicoParaReceberDeRelatorio.Id;
            servico.Nome_pet = servicoParaReceberDeRelatorio.Nome_pet;
            servico.Nome_proprietario = servicoParaReceberDeRelatorio.Nome_proprietario;
            servico.Valor = servicoParaReceberDeRelatorio.Valor;
            servico.Forma_pagamento = servicoParaReceberDeRelatorio.Forma_pagamento;
            servico.Observacoes = servicoParaReceberDeRelatorio.Observacoes;
            servico.Data = servicoParaReceberDeRelatorio.Data;
            editar_servico = editar;
            InitializeComponent();
        }
        /*
        * -------------------------------------------------------------------------------------------
        */

        /*
        * [ INICIO ] OPÇÃO SAIR/FECHAR DO MENU
        */
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /*
        * -------------------------------------
        */

        /*
        * [ INICIO ] CLICK DO BOTÃO SALVAR SERVIÇO
        */
        private void btn_salvarServico_Click(object sender, EventArgs e)
        {

            textBox_valor.Text = Util.trocarDigitos(textBox_valor);
            bool cancelarRegistro = false;


            DialogResult dialogResult = MessageBox.Show("Deseja realmente confirmar o cadastro?", "Confirmar novo cadastro", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            { 
                if (editar_servico)
                {
                    String data = dateTimePicker_servico.Text.ToString();
                    servico.Nome_pet = textBox_nomePet.Text;
                    servico.Nome_proprietario = textBox_nomeProprietario.Text;
                    servico.Valor = textBox_valor.Text;
                    servico.Forma_pagamento = comboBox_formaPagamento.Text;
                    servico.Data = data;
                    servico.Hora = DateTime.Now.Hour.ToString()+":"+DateTime.Now.Minute.ToString();
                    servico.Observacoes = textBox_observacoes.Text;

                    servicosController.AlterarServico(servico);
                    limparCampos();
                    dateTimePicker_servico.Enabled = false;
                    cancelarRegistro = false;
                    Close();
                    relatoriosForm.ShowDialog();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                textBox_valor.Focus();
                cancelarRegistro = true;
            }

            if (!cancelarRegistro)
            {
                if (!editar_servico)
                {
                    if (usuario.Login != "ADMIN") {
                        textBox_valor.Text = Util.trocarDigitos(textBox_valor);
                        dateTimePicker_servico.Enabled = false;
                        if (Util.validarCampos(textBox_nomePet, textBox_nomeProprietario, textBox_valor, comboBox_formaPagamento))
                        {

                            servico.Nome_pet = textBox_nomePet.Text;
                            servico.Nome_proprietario = textBox_nomeProprietario.Text;
                            servico.Valor = textBox_valor.Text;
                            servico.Forma_pagamento = comboBox_formaPagamento.Text;
                            servico.Observacoes = textBox_observacoes.Text;
                            servico.Hora = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
                            servicosController.SalvarServico(servico);
                            limparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Os campos devem ser preenchidos com excessão do campo 'Observações'.");
                            textBox_nomePet.Focus();
                        }
                    } else {
                        if (usuario.Login == "ADMIN")
                        {
                            textBox_valor.Text = Util.trocarDigitos(textBox_valor);

                            if (Util.validarCampos(textBox_nomePet, textBox_nomeProprietario, textBox_valor, comboBox_formaPagamento))
                            {
                                String data = dateTimePicker_servico.Text.ToString();
                                servico.Nome_pet = textBox_nomePet.Text;
                                servico.Nome_proprietario = textBox_nomeProprietario.Text;
                                servico.Valor = textBox_valor.Text;
                                servico.Forma_pagamento = comboBox_formaPagamento.Text;
                                servico.Data = data;
                                servico.Observacoes = textBox_observacoes.Text;
                                servico.Hora = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
                                servicosController.SalvarServicoADM(servico);
                                limparCampos();
                                dateTimePicker_servico.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Os campos devem ser preenchidos com excessão do campo 'Observações'.");
                                textBox_nomePet.Focus();
                            }
                        }
                    }
                }
            }
        }
        /*
         * ----------------------------------------
         */

        /*
         *  [ INICIO ] TEXTCHANGED DO TEXTBOX NOMEPET
         */
        private void textBox_nomePet_TextChanged(object sender, EventArgs e)
        {
           
            servicosController.nomePetTextChanged(textBox_nomePet, listView_servicosEncontrados, variacao);
        }
        /*
         *  -----------------------------------------
         */

        /*
         *  DUPLO CLIQUE NO ITEM DO LISTVIEW PARA JOGAR OS DADOS DO NOME PET E NOME PRO NOS TEXTBOXES
         */
        private void listView_servicosEncontrados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            servicosController.duploCliqueListaServico(
                listView_servicosEncontrados,
                textBox_nomePet,
                textBox_nomeProprietario,
                textBox_valor,
                dateTimePicker_servico);
            comboBox_formaPagamento.Focus();
        }
        /*
        * -------------------------------------------------------------------------------------------
        */

        /*
        * [ INICIO ] PERMITIR SOMENTE A INCLUSÃO DE DIGITOS, "," E APAGAR VALORES NO TEXTBOX_VALOR
        */
        private void textBox_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            

        }
        /*
        * ----------------------------------------------------------------------------------------
        */

        /*
        * [ INICIO ] LOAD DA TELA CADASTRAR SERVIÇO
        *           CASO EDITAR_SERVIÇO = TRUE ENTÃO
        *           TRAS OS DADOS SELECIONADOS E JOGA NOS TEXTBOXES
        *           SENAO
        *           EDITAR_SERVICO = FALSE
        *           NOVO CADASTRO
        */
        private void CadastrarServicoForm_Load(object sender, EventArgs e)
        {
            bool adm = false;
            if (usuario.Login == "ADMIN")
            {
                adm = true;
                dateTimePicker_servico.Visible = true;
            }  else {
                adm = false;
            }
            if (editar_servico)
            {
                textBox_nomePet.Text = servico.Nome_pet;
                textBox_nomeProprietario.Text = servico.Nome_proprietario;
                textBox_valor.Text = servico.Valor;
                comboBox_formaPagamento.Text = servico.Forma_pagamento;
                textBox_observacoes.Text = servico.Observacoes;
                textBox_nomePet.Focus();
                dateTimePicker_servico.Value = DateTime.Parse(servico.Data);
                dateTimePicker_servico.Visible = true;
            }
            
            if (editar_servico && adm)
            {
                dateTimePicker_servico.Visible = true;
            } else if (adm && !editar_servico)
            {
                String date = DateTime.Now.Day.ToString()+"/"+ DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
                dateTimePicker_servico.Value = DateTime.Parse(date);
                dateTimePicker_servico.Visible = true;
            } else
            {
                dateTimePicker_servico.Visible = false;
            }
            label_Login.Text = usuario.Login;
            
        }
        /*
        * ---------------------------------------------------------------
        */

        /*
        * [ INICIO ] METODO PARA TROCAR DE PULAR PROXCAMPO COM "ENTER" USANDO SERVICOSCONTROLLER E
        *               SE PRECIONAR ESC FECHA O FORM
        */
        private void trocarCampoComEnter(object sender, KeyEventArgs e)
        {
            servicosController.pulaProxCampo(sender, e);
            if ((e.KeyCode == Keys.Escape))
            {
                Close();
            }
            teclaAtalhoParaListaPetsPros(sender, e);
        }
        /*
        * ----------------------------------------------------------------------------------------
        */

       /*
       * [ INICIO ] METODO PARA FECHAR A FORM TECLANDO "ESC" Escape
       */
        public void fecharFormComEsc(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Escape))
            {
                Close();
            }
        }
        /*
         * -----------------------------------------------------------
         */

        /*
        * [ INICIO ] METODO PARA LIMPAR CAMPOS APÓS INCLUSÃO OU ALTERAÇÃO
        */
        public void limparCampos()
        {
            textBox_nomePet.Text = "";
            textBox_nomePet.Focus();
            textBox_nomeProprietario.Text = "";
            textBox_valor.Text = "";
            comboBox_formaPagamento.Text = "SELECIONE";
            textBox_observacoes.Text = "";
        }
        /*
        * -----------------------------------------------------------------
        */

        /*
      * [ INICIO ] METODO PARA FECHAR A FORM TECLANDO "ESC" Escape
      */
        public void teclaAtalhoParaListaPetsPros(object sender, KeyEventArgs e)
        {
            if (listView_servicosEncontrados.Visible == true && listView_servicosEncontrados.Items.Count > 0)
            {
                if ((e.KeyCode == Keys.F3))
                {
                    listView_servicosEncontrados.Focus();
                }
            }
            
        }
        /*
         * -----------------------------------------------------------
         */
        /*
         * [ INICIO ] METODO PARA FECHAR A FORM TECLANDO "ESC" Escape
         */
        public void selecionarItemComEnter(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                servicosController.duploCliqueListaServico(
                listView_servicosEncontrados,
                textBox_nomePet,
                textBox_nomeProprietario,
                textBox_valor,
                dateTimePicker_servico);
                comboBox_formaPagamento.Focus();
            }
        }

        private void textBox_nomePet_KeyPress(object sender, KeyPressEventArgs e)
        {
            // bloqear apostrofo ' = conflito e erro com o comando SQL
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
            }
        }
        
        /*
* -----------------------------------------------------------
*/
    }

}
