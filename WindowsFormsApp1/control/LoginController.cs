using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class LoginController
    {
        public bool habilitarDatePickerADM(Usuario usuario, bool adm, DateTimePicker dateTimePicker)
        {
            if (usuario.Login == "ADMIN")
            {
                adm = true;
                dateTimePicker.Visible = true;
            }
            else
            {
                adm = false;
            }
            return adm;
        }   
    }
}
