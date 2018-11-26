using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Util
    {
        /* 
         * [INICIO] CLIQUE DO BOTÃO GERAR RELATORIO EXCEL
         */
        static public void gerarExcel(ListView listView)
        {
            int quantidade = listView.Items.Count;
            if (quantidade >= 1)
            {
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Excel |* .xlsx",
                    InitialDirectory = @"c:\dados\xlsx",
                    FileName = "DadosListView_Excel_" + DateTime.Now.Millisecond.ToString() + ".xlsx",
                    ValidateNames = true
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)app.ActiveSheet;
                        app.Visible = false;

                        ws.Cells[1, 1] = "ID";
                        ws.Cells[1, 3] = "PET";
                        ws.Cells[1, 6] = "PROPRIETÁRIO";
                        ws.Cells[1, 9] = "VALOR";
                        ws.Cells[1, 12] = "FORMA DE PAGAMENTO";
                        ws.Cells[1, 15] = "OBSERVAÇÕES";
                        ws.Cells[1, 18] = "DATA";
                        //ws.Cells[1, 21] = "HORÁRIO";

                        int i = 2;
                        foreach (ListViewItem item in listView.Items)
                        {
                            ws.Cells[i, 1] = item.SubItems[0].Text;
                            ws.Cells[i, 3] = item.SubItems[2].Text;
                            ws.Cells[i, 6] = item.SubItems[3].Text;
                            ws.Cells[i, 9] = item.SubItems[4].Text;
                            ws.Cells[i, 12] = item.SubItems[5].Text;
                            ws.Cells[i, 15] = item.SubItems[6].Text;
                            ws.Cells[i, 18] = item.SubItems[1].Text;
                            //ws.Cells[i, 21] = item.SubItems[6].Text;
                            i++;
                        }
                        wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange,
                        XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                        MessageBox.Show("Seus dados foram exportados para o Excel com sucesso");
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecione o tipo de RELATÓRIO antes de continuar.");
            }
        }
        /* 
         * [FIM] ----------------------------------------
         */

        /*
         *  VALIDAÇÃO DE CAMPOS VAZIOS BOOLEANO
         */
        static public Boolean validarCampos(System.Windows.Forms.TextBox textBox_nomePet, System.Windows.Forms.TextBox textBox_nomeProprietario, System.Windows.Forms.TextBox textBox_valor, System.Windows.Forms.ComboBox comboBox_formaPagamento)
        { 
            bool validacao = false;
            if (textBox_nomePet.Text == "" || textBox_nomePet.Text.Length < 2)
            {
                validacao = false;
            }
            else if (textBox_nomeProprietario.Text == "" || textBox_nomeProprietario.Text.Length < 2)
            {
                validacao = false;
            }
            else if (textBox_valor.Text == "" || textBox_nomeProprietario.Text.Length < 2)
            {
                validacao = false;
            }
            else if (comboBox_formaPagamento.Text == "" || comboBox_formaPagamento.Text == "selecione")
            {
                validacao = false;
            }
            else
            {
                validacao = true;
            }
            return validacao;
        }
        /*
         * ------------------------------------
         */

        /*
        * [ INICIO ] METODO PARA CONVERTER TEXTVALOR EM MOEDA E PASSAR PARA STRING DENOVO
        */
        static public String trocarDigitos(System.Windows.Forms.TextBox textBoxvalor)
        {

            if (textBoxvalor.Text.Contains("R$") || textBoxvalor.Text.Contains(" "))
            {
                textBoxvalor.Text = textBoxvalor.Text.Replace("R$", "");
                textBoxvalor.Text = textBoxvalor.Text.Replace(" ", "");
            }

            String valor1 = textBoxvalor.Text;
            int quant = textBoxvalor.Text.Length;

            if (!textBoxvalor.Text.Contains(','))
            {
                if (quant == 2 || quant == 3)
                {
                    valor1 = textBoxvalor.Text + ",00";
                }
                if (quant == 4)
                {
                    valor1 = textBoxvalor.Text;
                    valor1 = valor1.Insert(3, ",").Insert(5, "0");
                }
                if (quant == 5)
                {
                    valor1 = textBoxvalor.Text;
                    valor1 = valor1.Insert(3, ",");
                }
                if (quant == 6)
                {
                    valor1 = textBoxvalor.Text;
                    valor1 = valor1.Insert(1, ".").Insert(5, ",");
                }
                if (quant == 7)
                {
                    valor1 = textBoxvalor.Text;
                    valor1 = valor1.Insert(2, ".").Insert(6, ",");
                }
            }
            else if (textBoxvalor.Text.Contains(','))
            {
                String[] valores = valor1.Split(',');
                if (valores[1].Length == 1)
                {
                    valor1 = valor1 + "0";
                }

                
            }

            return "R$ "+valor1;
        }
        /*
        * -------------------------------------------------------------------------------
        */

        /*
        * [ INICIO ] METODO FAZER BACKUP DO BD
        */
        static public void backup()
        {
            Conexao conexao = new Conexao();
            String file1="", file2 ="", constring="";
            conexao.stringParaBackup(constring, file1,file2);
            
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file1);
                        mb.ExportToFile(file2);
                        conn.Close();
                    }
                }
            }
        }
        /*
        * ------------------------------------
        */





    }
}
