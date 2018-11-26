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
    public partial class CadastrarUsuarioForm : Form
    {
        public CadastrarUsuarioForm()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastrarUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    if (textBox_Login.Text.ToUpper() == "ADMIN" || textBox_Login.Text.ToUpper() == "ADMINN")
                    {
                        MessageBox.Show("Login não é permitido.");
                        textBox_Login.Text = "";
                        textBox_Login.Focus();
                        textBox_Senha.Text = "";
                    } else
                    {
                        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user id=root;database=db_prontovet");
                        conn.Open();
                        MySqlCommand bdcommand = new MySqlCommand("INSERT INTO tb_usuarios " +
                            "(login," +
                            "senha) VALUES (?,?)", conn);

                        bdcommand.Parameters.Add("@login", MySqlDbType.Text).Value = textBox_Login.Text.ToUpper();
                        bdcommand.Parameters.Add("@senha", MySqlDbType.Double).Value = textBox_Senha.Text.ToUpper();

                        bdcommand.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!");

                        textBox_Login.Text = "";
                        textBox_Senha.Text = "";
                        textBox_Login.Focus();

                        conn.Close();
                    }
                    
                }
                catch (Exception error)
                {
                    MessageBox.Show("Falha no bd." + error);
                }
            } else
            {
                MessageBox.Show("Algum campo está em branco ou com 3 ou menos caracteres.");
                textBox_Login.Focus();
            }
        }

        // VALIDAR CAMPOS
        public bool validarCampos()
        {
            bool validado = false;

            if (textBox_Login.Text == "" || textBox_Login.Text.Length < 3)
            {
                validado = false;
            } else if (textBox_Senha.Text == "" || textBox_Senha.Text.Length < 3)
            {
                validado = false;
            } else
            {
                validado = true;
            }



            return validado;
        }
    }
}
