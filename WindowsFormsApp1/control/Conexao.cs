using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Conexao
    {

        public MySqlConnection conectarBD()
        {

            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user id=root;database=db_prontovet");
            return conn;
        }

        public void stringParaBackup(String constring, String src1, String src2)
        {

            constring = "server=localhost;user=root;database=db_prontovet;";
            src1 = "C:/prontovetdb_backup/db_prontovet_backup_" + DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + ".sql";
            src2 = "C:/prontovetdb_backup/db_prontovet_backup_" + DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + ".sql";

        }

    }
}
