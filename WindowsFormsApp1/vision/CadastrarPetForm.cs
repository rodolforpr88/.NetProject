﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPagamento
{
    public partial class CadastrarPetForm : Form
    {
        public CadastrarPetForm()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastrarPetForm_Load(object sender, EventArgs e)
        {
            // ADICIONANDO ITEMS PARA O COMBOBOX DE "TIPO"
            comboBoxTipoPet.Items.Add("Cachorro");
            comboBoxTipoPet.Items.Add("Gato");

        }

        private void btn_LimparPet_Click(object sender, EventArgs e)
        {

        }
    }
}
