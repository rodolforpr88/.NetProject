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

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        String loginUsuario = "";
        String senhaUsuario = "";
        ServicosController ServicosController = new ServicosController();
        Conexao conexao = new Conexao();

        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(String login, String senha)
        {

            
        }

        /*
        * [ INICIO ] METODO PARA LOGAR COM O CLICK DO BOTAO LOGAR
        */
        private void button_Logar_Click(object sender, EventArgs e)
        {        
            try
            {
                if (textBox_login.Text != "" && textBox_senha.Text != "")
                {
                    MySqlConnection conn = conexao.conectarBD();
                    if (!conn.Ping())
                    {
                        conn.Open();
                    }
                    MySqlCommand bdcommand = new MySqlCommand("SELECT login,senha FROM tb_usuarios WHERE login = '" +
                    textBox_login.Text.ToUpper() + "' AND senha = '" +
                    textBox_senha.Text.ToUpper() + "'", conn);


                    MySqlDataReader reader;
                    reader = bdcommand.ExecuteReader();

                    if (reader.Read())
                    {
                        loginUsuario = reader.GetString(0);
                        senhaUsuario = reader.GetString(1);

                    }


                    if (textBox_login.Text.ToUpper() == loginUsuario.ToUpper() && textBox_senha.Text.ToUpper() == senhaUsuario.ToUpper())
                    {
                        textBox_login.Text = "";
                        textBox_login.Focus();
                        textBox_senha.Text = "";
                        MenuPrincipal telaPrincipal = new MenuPrincipal(loginUsuario, senhaUsuario);
                        CadastrarServicoForm cadastrarServicos = new CadastrarServicoForm(loginUsuario, senhaUsuario);
                        telaPrincipal.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Login Inválido.");

                    }

                    conn.Close();
                } else
                {
                    MessageBox.Show("Preencha os campos antes de continuar.");
                    textBox_login.Focus();
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro>>>"+error);
            }
        }
        /*
        * --------------------------------------------------------------------
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
        * [ INICIO ] METODO PARA LOGAR COM ENTER
        */
        public void LogarComEnter(object sender, KeyEventArgs e)
        {
            
            if ((e.KeyCode == Keys.Enter))
            {
                try
                {
                    if (textBox_login.Text != "" && textBox_senha.Text != "")
                    {
                        MySqlConnection conn = conexao.conectarBD();
                        conn.Open();
                        MySqlCommand bdcommand = new MySqlCommand("SELECT login,senha FROM tb_usuarios WHERE login = '" +
                        textBox_login.Text.ToUpper() + "' AND senha = '" +
                        textBox_senha.Text.ToUpper() + "'", conn);

                        MySqlDataReader reader;
                        reader = bdcommand.ExecuteReader();

                        if (reader.Read())
                        {
                            loginUsuario = reader.GetString(0);
                            senhaUsuario = reader.GetString(1);

                        }


                        if (textBox_login.Text.ToUpper() == loginUsuario.ToUpper() && textBox_senha.Text.ToUpper() == senhaUsuario.ToUpper())
                        {
                            MessageBox.Show("Login feito com sucesso!");
                            textBox_login.Text = "";
                            textBox_login.Focus();
                            textBox_senha.Text = "";
                            MenuPrincipal telaPrincipal = new MenuPrincipal(loginUsuario, senhaUsuario);
                            CadastrarServicoForm cadastrarServicos = new CadastrarServicoForm(loginUsuario, senhaUsuario);
                            telaPrincipal.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Login Inválido.");
                        }

                        conn.Close();
                    } else
                    {
                        MessageBox.Show("Preencha os campos antes de continuar.");
                        textBox_login.Focus();
                    }
                    
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro>>>" + error);
                }
            }
        }
        /*
         * -----------------------------------------------------------
         */

        /*
        * [INICIO] METODO PARA PULAR DE TEXTBOX QND APERTAR "ENTER"
        */
        public void fecharEpularCampos(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            } else if ((e.KeyCode == Keys.Escape)) {
                Close();
            }
        }
        /*
         * -----------------------------------------------------------
         */
    }
}
