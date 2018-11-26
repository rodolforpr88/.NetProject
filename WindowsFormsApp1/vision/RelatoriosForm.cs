using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class RelatoriosForm : Form
    {
        RelatoriosController relatoriosController = new RelatoriosController();
        ServicosController servicosController = new ServicosController();
        Servico servico = new Servico();
        public RelatoriosForm()
        {
            InitializeComponent();
        }
        // LOAD DO FORM
        private void RelatoriosForm_Load(object sender, EventArgs e)
        {
            comboBox_mes.Text = DateTime.Now.Month.ToString().ToUpper();
            comboBox_ano.Text = DateTime.Now.Year.ToString().ToUpper();
            relatoriosController.listarMesAtual(listView_servicos);
        }
        /*
         * -----------------------------------------------------------
         */
        // OPÇÃO PARA FECHAR O FORM QUANDO FOR CLICADO EM SAIR/VOLTAR
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }
        /*
         * -----------------------------------------------------------
         */
        // BOTÃO PARA GERAR RELATORIO NO EXCEL
        private void button_relatorioExcel_Click(object sender, EventArgs e)
        {

            Util.gerarExcel(listView_servicos);
        }
        /*
         * -----------------------------------------------------------
         */

        // BOTÃO PARA GERAR RELATORIO MENSAL NO LISTVIEW
        private void button_relatorioMensal_Click(object sender, EventArgs e)
        {
            if (int.Parse(comboBox_mes.Text) >= 01 && int.Parse(comboBox_mes.Text) <= 12)
            {
                if (int.Parse(comboBox_ano.Text) >= 2018 && int.Parse(comboBox_ano.Text) <= 2050)
                {
                    relatoriosController.selecionarPorMes(listView_servicos, comboBox_mes, comboBox_ano); 
                }
                else
                {
                    MessageBox.Show("O valor do ano deve ser digitado entre 2018-2050");
                    relatoriosController.comboBoxesMesEAnoAtual(comboBox_mes, comboBox_ano);
                }
            }
            else
            {
                MessageBox.Show("O valor do mês deve ser digitado entre 01-12");
                relatoriosController.comboBoxesMesEAnoAtual(comboBox_mes, comboBox_ano);
            }
        }
        /*
         * -----------------------------------------------------------
         */

        // BOTÃO PARA GERAR RELATORIO ANUAL NO LISTVIEW
        private void button_relatorioAnual_Click(object sender, EventArgs e)
        {
            if (int.Parse(comboBox_ano.Text) >= 2018 && int.Parse(comboBox_ano.Text) <= 2050)
            {
                relatoriosController.selecionarPorAno(listView_servicos, comboBox_ano);
            } else
            {
                MessageBox.Show("O valor do ano deve ser digitado entre 2018-2050");
                relatoriosController.comboBoxesMesEAnoAtual(comboBox_mes, comboBox_ano);
            } 
        }
        /*
         * -----------------------------------------------------------
         */
        // GERAR RELATÓRIO PARA (NOME_PET, NOME_PROPRIETARIO, FORMA_PAGAMENTO E OBSERVAÇÕES)
        private void textBox_textoPesquisa_TextChanged(object sender, EventArgs e)
        {
  
            relatoriosController.gerarRelatorioporTexto(listView_servicos, textBox_textoPesquisa);
        }
        /*
         * -----------------------------------------------------------
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
            servicosController.pulaProxCampo(sender,e);
        }
        /*
         * -----------------------------------------------------------
         */

       /*
       * [ INICIO ] QUESTIONA SE VAI QUERER EDITAR O ITEM CLICADO2X 
       */
        private void listView_servicos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Abrir tela para edição do item selecionado?", "Editar item?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                opcaoEdicao();
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        /*
       * ------------------------------------------------------------
       */


        private void button_todosRegistros_Click(object sender, EventArgs e)
        {
            relatoriosController.selectRelatoriosCompleto(listView_servicos);
        }

        /*
         * [ INICIO ] VERIFICAR SE COMBOS DE ANO E MES ESTÂO ATIVOS
         */
        private void comboBox_ano_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_ano.Text == "" || comboBox_ano.Text.Length == 0)
            {
                RelatoriosController relatorioController = new RelatoriosController();
                relatorioController.comboBoxesMesEAnoAtual(comboBox_mes, comboBox_ano);
            }
        }
        /*
         * ---------------------------------------------------------
         */

        /*
         * [ INICIO ] OPÇÃO EDITAR
         */
        public void opcaoEdicao()
        {
            
            duploCliqueEdicao(listView_servicos, servico);
            bool editar = true;
            CadastrarServicoForm cadastrarServicoForm = new CadastrarServicoForm(editar, servico);
            cadastrarServicoForm.ShowDialog();
        }
        /*
         * -----------------------
         */

        /*
         * [ INICIO ] DUPLO CLIQUE NA LISTVIEW E JOGA OS DADOS CLICADO NOS TEXTBOX's
         */
        public void duploCliqueEdicao(ListView listViewEncontrados,Servico servicoParaEdicao)
        {
            servicoParaEdicao.Id = int.Parse(listViewEncontrados.SelectedItems[0].SubItems[0].Text);
            servicoParaEdicao.Data = listViewEncontrados.SelectedItems[0].SubItems[1].Text;
            servicoParaEdicao.Nome_pet = listViewEncontrados.SelectedItems[0].SubItems[2].Text;
            servicoParaEdicao.Nome_proprietario = listViewEncontrados.SelectedItems[0].SubItems[3].Text;
            servicoParaEdicao.Valor = listViewEncontrados.SelectedItems[0].SubItems[4].Text;
            servicoParaEdicao.Forma_pagamento = listViewEncontrados.SelectedItems[0].SubItems[5].Text;
            servicoParaEdicao.Observacoes = listViewEncontrados.SelectedItems[0].SubItems[6].Text;
        }
        /*
         * -------------------------------------------------------------------------
         */

        /*
        * [ INICIO ] METODO PARA FECHAR A FORM TECLANDO "ESC" Escape
        */
        public void deletarComDEL(object sender, KeyEventArgs e)
        {
            fecharFormComEsc(sender, e);
            
            if ((e.KeyCode == Keys.Delete))
            {
                int idExclusao = int.Parse(listView_servicos.SelectedItems[0].SubItems[0].Text);
                if (idExclusao > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o item selecionado?", "Excluir item?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ServicosController servicosController = new ServicosController();
                        servicosController.deletarServico(idExclusao, listView_servicos);
                    }
                    //else if (dialogResult == DialogResult.No)
                    //{
                        // faça algo...
                    //}
                }
               
            } else
            if ((e.KeyCode == Keys.Escape))
            {
                Close();
            }
        }
        /*
         * ---------------------------------------------------------
         */

        private void comboBox_mes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void comboBox_ano_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }*/
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void comboBox_mes_Leave(object sender, EventArgs e)
        {
            
            if (comboBox_mes.Text == "" || comboBox_mes.Text.Length == 0)
            {
                relatoriosController.comboBoxesMesEAnoAtual(comboBox_mes, comboBox_ano);
            }
            
        }
    }
}
