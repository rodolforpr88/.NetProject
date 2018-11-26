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
    static class ExcelController
    {
        

        static public void importarExcel(Servico servico, ServicosController servicosController, String folhaDoExcel)
        {
            OleDbConnection conexao = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\prontovetdb_backup\\Pagos.xlsx;Extended Properties='Excel 12.0 Xml;HDR = YES';");
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from["+folhaDoExcel+"$]", conexao);
            DataSet ds = new DataSet();
            try
            {
                conexao.Open();
                adapter.Fill(ds);
                foreach (DataRow linha in ds.Tables[0].Rows)
                {
                    String[] list = linha["PET - PROPRIETÁRIO"].ToString().Split('-');
                    try
                    {
                        if (linha["PET - PROPRIETÁRIO"].ToString() != "")
                        {
                            servico.Nome_pet = list[0].ToString().ToUpper();
                            servico.Nome_proprietario = list[1].ToString().ToUpper();
                            servico.Valor = linha["VALOR"].ToString().ToUpper();
                            servico.Forma_pagamento = linha["FORMA DE PAGAMENTO"].ToString().ToUpper();
                            servico.Observacoes = linha["OBSERVAÇÃO"].ToString().ToUpper();
                            servico.Data = linha["DATA"].ToString().ToUpper();
                            servico.Hora = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
                            servicosController.SalvarServicoExcel(servico);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Erro (importarExcel - Util): " + e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro (importarExcel catch - Util): " + ex);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
