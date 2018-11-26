using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Servico
    {
        private int id;
        private String data;
        private string nome_pet;
        private string nome_proprietario;
        private string valor;
        private string forma_pagamento;
        private string observacoes;
        private string hora;

        public string Nome_pet { get => nome_pet; set => nome_pet = value; }
        public string Nome_proprietario { get => nome_proprietario; set => nome_proprietario = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Forma_pagamento { get => forma_pagamento; set => forma_pagamento = value; }
        public string Observacoes { get => observacoes; set => observacoes = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Data { get => data; set => data = value; }
        public int Id { get => id; set => id = value; }


    }
}
