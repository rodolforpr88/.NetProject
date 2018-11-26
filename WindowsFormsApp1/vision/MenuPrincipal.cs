using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class MenuPrincipal : Form
    {
        String loginUser;
        String senhaUser;
        Conexao conexao = new Conexao();
        ServicosController servicosController = new ServicosController();
        Servico servico = new Servico();
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        public MenuPrincipal(String login, String senha)
        {
            
            loginUser = login;
            senhaUser = senha;
            InitializeComponent();
            try
            {
                MySqlConnection conn = conexao.conectarBD();
                conn.Open();
                conn.Close();
            } catch (Exception e)
            {
                MessageBox.Show("Erro ao conecatar com o Banco de Dados: Verifique se o programa 'WAMPSERVER64' esta aberto e com o desenho na cor VERDE."+e);
            }
        }

            /*
            * [ INICIO ] LOAD DO FORM1 (TELA PRINCIPAL)
            */
            private void Form1_Load(object sender, EventArgs e)
        {
            checarAdmin(loginUser);
            label_Login.Text = loginUser;
        }
        /*
         * ----------------------------------------
         */
        /*
         * [ INICIO ] QUANDO FORM1 (TELA PRINCIPAL) FOR FECHADA = BACKUP AUTOMATICO DO BD
         */
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Util.backup();
        }
        /*
         * ------------------------------------------------------------------------------
         */
        /*
        * [ INICIO ] OPCAO "SAIR" DO MENU + BACKUP AUTOMATICO
        */
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /*
         * ---------------------------------------------------
         */
        /*
         * [ INICIO ] OPCAO "USUARIO" DO MENU
         */
        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarUsuarioForm cadastrarUsuarioForm = new CadastrarUsuarioForm();
            cadastrarUsuarioForm.ShowDialog();
        }
        /*
         * ----------------------------------
         */
        /*
         * [ INICIO ] OPCAO "SERVICO" DO MENU SUBMENU DE CADASTRAR
         */
        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarServicoForm cadastrarServicoForm = new CadastrarServicoForm(loginUser,senhaUser);
            cadastrarServicoForm.ShowDialog();
        }
        /*
         * -------------------------------------------------------
         */
        /*
        * [ INICIO ] OPCAO "RELATORIOS" DO MENU
        */
        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatoriosForm relatoriosForm = new RelatoriosForm();
            relatoriosForm.ShowDialog();
        }
        /*
         * ------------------------------------
         */
        /*
        * [ INICIO ] METODO PARA CHECAR SE USUARIO É ADM
        */
        public void checarAdmin(String login)
        {
            if (login == "ADMIN")
            {
                relatóriosToolStripMenuItem.Enabled = true;
                usuárioToolStripMenuItem.Enabled = true;
            } else
            {
                relatóriosToolStripMenuItem.Enabled = false;
                usuárioToolStripMenuItem.Enabled = false;
            }
        }
        /*
         * ----------------------------------------------
         */
        /*
         * [ INICIO ] OPCAO "BACKUP" DO MENU
         */
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //String folhaExcel = "NOV";
                //ExcelController.importarExcel(servico, servicosController, folhaExcel);
                //Util.backup();
                MessageBox.Show("Backup realizado com sucesso!");
            } catch (Exception error)
            {
                MessageBox.Show("Erro ao efetuar backup: "+ error);
            }
            MessageBox.Show("Importação realizada com sucesso!");
        }
        /*
         * ----------------------------------
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

    }
}
