namespace WindowsFormsApp1
{
    partial class RelatoriosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatoriosForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_servicos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_relatorioExcel = new System.Windows.Forms.Button();
            this.button_relatorioMensal = new System.Windows.Forms.Button();
            this.button_relatorioAnual = new System.Windows.Forms.Button();
            this.comboBox_mes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_ano = new System.Windows.Forms.ComboBox();
            this.textBox_textoPesquisa = new System.Windows.Forms.TextBox();
            this.button_todosRegistros = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 37);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(143, 33);
            this.sairToolStripMenuItem.Text = "Sair/Voltar";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // listView_servicos
            // 
            this.listView_servicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_servicos.AutoArrange = false;
            this.listView_servicos.BackColor = System.Drawing.SystemColors.Window;
            this.listView_servicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_servicos.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_servicos.FullRowSelect = true;
            this.listView_servicos.GridLines = true;
            this.listView_servicos.HideSelection = false;
            this.listView_servicos.Location = new System.Drawing.Point(12, 107);
            this.listView_servicos.MultiSelect = false;
            this.listView_servicos.Name = "listView_servicos";
            this.listView_servicos.ShowGroups = false;
            this.listView_servicos.Size = new System.Drawing.Size(1247, 359);
            this.listView_servicos.TabIndex = 7;
            this.listView_servicos.UseCompatibleStateImageBehavior = false;
            this.listView_servicos.View = System.Windows.Forms.View.Details;
            this.listView_servicos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.deletarComDEL);
            this.listView_servicos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_servicos_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 208;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pet";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 210;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Proprietário";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 218;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Valor";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 211;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pagamento";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 174;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Observações";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 400;
            // 
            // button_relatorioExcel
            // 
            this.button_relatorioExcel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_relatorioExcel.Location = new System.Drawing.Point(545, 40);
            this.button_relatorioExcel.Name = "button_relatorioExcel";
            this.button_relatorioExcel.Size = new System.Drawing.Size(151, 61);
            this.button_relatorioExcel.TabIndex = 5;
            this.button_relatorioExcel.Text = "Gerar Relatório Excel";
            this.button_relatorioExcel.UseVisualStyleBackColor = true;
            this.button_relatorioExcel.Click += new System.EventHandler(this.button_relatorioExcel_Click);
            this.button_relatorioExcel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecharFormComEsc);
            // 
            // button_relatorioMensal
            // 
            this.button_relatorioMensal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_relatorioMensal.Location = new System.Drawing.Point(419, 40);
            this.button_relatorioMensal.Name = "button_relatorioMensal";
            this.button_relatorioMensal.Size = new System.Drawing.Size(120, 61);
            this.button_relatorioMensal.TabIndex = 4;
            this.button_relatorioMensal.Text = "Relatório Mensal";
            this.button_relatorioMensal.UseVisualStyleBackColor = true;
            this.button_relatorioMensal.Click += new System.EventHandler(this.button_relatorioMensal_Click);
            this.button_relatorioMensal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecharFormComEsc);
            // 
            // button_relatorioAnual
            // 
            this.button_relatorioAnual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_relatorioAnual.Location = new System.Drawing.Point(293, 40);
            this.button_relatorioAnual.Name = "button_relatorioAnual";
            this.button_relatorioAnual.Size = new System.Drawing.Size(120, 61);
            this.button_relatorioAnual.TabIndex = 3;
            this.button_relatorioAnual.Text = "Relatório Anual";
            this.button_relatorioAnual.UseVisualStyleBackColor = true;
            this.button_relatorioAnual.Click += new System.EventHandler(this.button_relatorioAnual_Click);
            this.button_relatorioAnual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecharFormComEsc);
            // 
            // comboBox_mes
            // 
            this.comboBox_mes.AutoCompleteCustomSource.AddRange(new string[] {
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.comboBox_mes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_mes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_mes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_mes.FormattingEnabled = true;
            this.comboBox_mes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox_mes.Location = new System.Drawing.Point(12, 59);
            this.comboBox_mes.Name = "comboBox_mes";
            this.comboBox_mes.Size = new System.Drawing.Size(130, 24);
            this.comboBox_mes.TabIndex = 1;
            this.comboBox_mes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecharFormComEsc);
            this.comboBox_mes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_mes_KeyPress);
            this.comboBox_mes.Leave += new System.EventHandler(this.comboBox_mes_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "MÊS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "FILTRO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "ANO";
            // 
            // comboBox_ano
            // 
            this.comboBox_ano.AutoCompleteCustomSource.AddRange(new string[] {
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.comboBox_ano.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_ano.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_ano.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ano.FormattingEnabled = true;
            this.comboBox_ano.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050"});
            this.comboBox_ano.Location = new System.Drawing.Point(148, 59);
            this.comboBox_ano.Name = "comboBox_ano";
            this.comboBox_ano.Size = new System.Drawing.Size(111, 24);
            this.comboBox_ano.TabIndex = 2;
            this.comboBox_ano.TextChanged += new System.EventHandler(this.comboBox_ano_TextChanged);
            this.comboBox_ano.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecharFormComEsc);
            this.comboBox_ano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_ano_KeyPress);
            // 
            // textBox_textoPesquisa
            // 
            this.textBox_textoPesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_textoPesquisa.Location = new System.Drawing.Point(97, 469);
            this.textBox_textoPesquisa.Name = "textBox_textoPesquisa";
            this.textBox_textoPesquisa.Size = new System.Drawing.Size(141, 26);
            this.textBox_textoPesquisa.TabIndex = 8;
            this.textBox_textoPesquisa.TextChanged += new System.EventHandler(this.textBox_textoPesquisa_TextChanged);
            this.textBox_textoPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecharFormComEsc);
            // 
            // button_todosRegistros
            // 
            this.button_todosRegistros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_todosRegistros.Location = new System.Drawing.Point(702, 40);
            this.button_todosRegistros.Name = "button_todosRegistros";
            this.button_todosRegistros.Size = new System.Drawing.Size(120, 61);
            this.button_todosRegistros.TabIndex = 6;
            this.button_todosRegistros.Text = "Todos Registros";
            this.button_todosRegistros.UseVisualStyleBackColor = true;
            this.button_todosRegistros.Click += new System.EventHandler(this.button_todosRegistros_Click);
            this.button_todosRegistros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecharFormComEsc);
            // 
            // RelatoriosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 761);
            this.Controls.Add(this.button_todosRegistros);
            this.Controls.Add(this.textBox_textoPesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_ano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_mes);
            this.Controls.Add(this.button_relatorioAnual);
            this.Controls.Add(this.button_relatorioMensal);
            this.Controls.Add(this.button_relatorioExcel);
            this.Controls.Add(this.listView_servicos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatoriosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProntoVet - Tela de Relatórios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelatoriosForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecharFormComEsc);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ListView listView_servicos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button_relatorioExcel;
        private System.Windows.Forms.Button button_relatorioMensal;
        private System.Windows.Forms.Button button_relatorioAnual;
        private System.Windows.Forms.ComboBox comboBox_mes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_ano;
        private System.Windows.Forms.TextBox textBox_textoPesquisa;
        private System.Windows.Forms.Button button_todosRegistros;
    }
}