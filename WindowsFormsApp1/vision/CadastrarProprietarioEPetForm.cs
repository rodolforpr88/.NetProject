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

namespace ProjetoPagamento.Resources
{
    public partial class CadastrarProprietarioForm : Form
    {
        public CadastrarProprietarioForm()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_LimparProprietario_Click(object sender, EventArgs e)
        {
            /*txtBox_NomeProprietario.Text = "";
            txtBox_EmailProprietario.Text = "";
            txtBox_Tel1Proprietario.Text = "";
            txtBox_Tel2Proprietario.Text = "";
            txtBox_NomeProprietario.Focus();*/
        }

        // --------------------------
        // CLICK DO BOTÃO "CADASTRAR"
        // --------------------------
        private void btn_CadastrarProprietario_Click(object sender, EventArgs e)
        {
            /*try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user id=root;database=db_prontovet");
                conn.Open();     
                MySqlCommand bdcommand = new MySqlCommand("INSERT INTO tb_proprietario " +
                    "(nome_proprietario," +
                    "email_proprietario," +
                    "telefone1_proprietario," +
                    "telefone2_proprietario) VALUES (?,?,?,?)",conn);
                bdcommand.Parameters.Add("@nome_proprietario",MySqlDbType.Text).Value = txtBox_NomeProprietario.Text;
                bdcommand.Parameters.Add("@email_proprietario",MySqlDbType.Text).Value = txtBox_EmailProprietario.Text;
                bdcommand.Parameters.Add("@telefone1_proprietario",MySqlDbType.Text).Value = txtBox_Tel1Proprietario.Text;
                bdcommand.Parameters.Add("@telefone2_proprietario",MySqlDbType.Text).Value = txtBox_Tel2Proprietario.Text;

                bdcommand.ExecuteNonQuery();
                MessageBox.Show("Cadastro salvo com sucesso!");


                txtBox_NomeProprietario.Text = "";
                txtBox_EmailProprietario.Text = "";
                txtBox_Tel1Proprietario.Text = "";
                txtBox_Tel2Proprietario.Text = "";
                txtBox_NomeProprietario.Focus();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Falha no bd.");
            }*/
        }
        // ---------------------------------
        // FIM DO CLICK DO BOTÃO "CADASTRAR"
        // ---------------------------------
    }
}
