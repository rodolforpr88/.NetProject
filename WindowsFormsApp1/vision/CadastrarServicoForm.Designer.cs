namespace WindowsFormsApp1
{
    partial class CadastrarServicoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarServicoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nomePet = new System.Windows.Forms.TextBox();
            this.textBox_nomeProprietario = new System.Windows.Forms.TextBox();
            this.listView_servicosEncontrados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_valor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_formaPagamento = new System.Windows.Forms.ComboBox();
            this.textBox_observacoes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salvarServico = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.dateTimePicker_servico = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR SERVIÇO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(143, 33);
            this.sairToolStripMenuItem.Text = "Sair/Voltar";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Pet";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome Proprietário";
            // 
            // textBox_nomePet
            // 
            this.textBox_nomePet.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nomePet.Location = new System.Drawing.Point(259, 186);
            this.textBox_nomePet.Name = "textBox_nomePet";
            this.textBox_nomePet.Size = new System.Drawing.Size(369, 32);
            this.textBox_nomePet.TabIndex = 1;
            this.textBox_nomePet.TextChanged += new System.EventHandler(this.textBox_nomePet_TextChanged);
            this.textBox_nomePet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trocarCampoComEnter);
            this.textBox_nomePet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nomePet_KeyPress);
            // 
            // textBox_nomeProprietario
            // 
            this.textBox_nomeProprietario.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nomeProprietario.Location = new System.Drawing.Point(259, 269);
            this.textBox_nomeProprietario.Name = "textBox_nomeProprietario";
            this.textBox_nomeProprietario.Size = new System.Drawing.Size(369, 32);
            this.textBox_nomeProprietario.TabIndex = 2;
            this.textBox_nomeProprietario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trocarCampoComEnter);
            // 
            // listView_servicosEncontrados
            // 
            this.listView_servicosEncontrados.BackColor = System.Drawing.SystemColors.Window;
            this.listView_servicosEncontrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_servicosEncontrados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_servicosEncontrados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_servicosEncontrados.FullRowSelect = true;
            this.listView_servicosEncontrados.GridLines = true;
            this.listView_servicosEncontrados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_servicosEncontrados.Location = new System.Drawing.Point(667, 186);
            this.listView_servicosEncontrados.MultiSelect = false;
            this.listView_servicosEncontrados.Name = "listView_servicosEncontrados";
            this.listView_servicosEncontrados.Size = new System.Drawing.Size(582, 364);
            this.listView_servicosEncontrados.TabIndex = 7;
            this.listView_servicosEncontrados.UseCompatibleStateImageBehavior = false;
            this.listView_servicosEncontrados.View = System.Windows.Forms.View.Details;
            this.listView_servicosEncontrados.Visible = false;
            this.listView_servicosEncontrados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.selecionarItemComEnter);
            this.listView_servicosEncontrados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_servicosEncontrados_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome do Pet";
            this.columnHeader1.Width = 265;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome do Proprietário";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 323;
            // 
            // textBox_valor
            // 
            this.textBox_valor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_valor.Location = new System.Drawing.Point(259, 442);
            this.textBox_valor.Name = "textBox_valor";
            this.textBox_valor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_valor.Size = new System.Drawing.Size(369, 32);
            this.textBox_valor.TabIndex = 4;
            this.textBox_valor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trocarCampoComEnter);
            this.textBox_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_valor_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Pago";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Forma de Pagamento";
            // 
            // comboBox_formaPagamento
            // 
            this.comboBox_formaPagamento.AutoCompleteCustomSource.AddRange(new string[] {
            "CHEQUE",
            "CRÉDITO",
            "DÉBITO",
            "VERBA"});
            this.comboBox_formaPagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_formaPagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_formaPagamento.Font = new System.Drawing.Font("Arial", 15.75F);
            this.comboBox_formaPagamento.Items.AddRange(new object[] {
            "CHEQUE",
            "CRÉDITO",
            "DÉBITO",
            "PARCELADO",
            "VERBA"});
            this.comboBox_formaPagamento.Location = new System.Drawing.Point(259, 358);
            this.comboBox_formaPagamento.Name = "comboBox_formaPagamento";
            this.comboBox_formaPagamento.Size = new System.Drawing.Size(369, 32);
            this.comboBox_formaPagamento.TabIndex = 3;
            this.comboBox_formaPagamento.Text = "SELECIONE";
            this.comboBox_formaPagamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trocarCampoComEnter);
            // 
            // textBox_observacoes
            // 
            this.textBox_observacoes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_observacoes.Location = new System.Drawing.Point(259, 553);
            this.textBox_observacoes.Name = "textBox_observacoes";
            this.textBox_observacoes.Size = new System.Drawing.Size(369, 32);
            this.textBox_observacoes.TabIndex = 6;
            this.textBox_observacoes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trocarCampoComEnter);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Observações";
            // 
            // btn_salvarServico
            // 
            this.btn_salvarServico.AutoSize = true;
            this.btn_salvarServico.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btn_salvarServico.Location = new System.Drawing.Point(394, 643);
            this.btn_salvarServico.Name = "btn_salvarServico";
            this.btn_salvarServico.Size = new System.Drawing.Size(183, 57);
            this.btn_salvarServico.TabIndex = 7;
            this.btn_salvarServico.Text = "SALVAR";
            this.btn_salvarServico.UseVisualStyleBackColor = true;
            this.btn_salvarServico.Click += new System.EventHandler(this.btn_salvarServico_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "USUÁRIO:";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.Color.DimGray;
            this.label_Login.Location = new System.Drawing.Point(120, 76);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(117, 22);
            this.label_Login.TabIndex = 15;
            this.label_Login.Text = "USERNAME";
            // 
            // dateTimePicker_servico
            // 
            this.dateTimePicker_servico.CustomFormat = "";
            this.dateTimePicker_servico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_servico.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_servico.Location = new System.Drawing.Point(259, 480);
            this.dateTimePicker_servico.MinDate = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            this.dateTimePicker_servico.Name = "dateTimePicker_servico";
            this.dateTimePicker_servico.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_servico.TabIndex = 5;
            this.dateTimePicker_servico.Value = new System.DateTime(2018, 11, 7, 0, 0, 0, 0);
            this.dateTimePicker_servico.Visible = false;
            // 
            // CadastrarServicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1384, 712);
            this.Controls.Add(this.dateTimePicker_servico);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_salvarServico);
            this.Controls.Add(this.textBox_observacoes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_formaPagamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_valor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView_servicosEncontrados);
            this.Controls.Add(this.textBox_nomeProprietario);
            this.Controls.Add(this.textBox_nomePet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarServicoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Serviços Pagos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastrarServicoForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecharFormComEsc);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nomePet;
        private System.Windows.Forms.TextBox textBox_nomeProprietario;
        private System.Windows.Forms.ListView listView_servicosEncontrados;
        private System.Windows.Forms.TextBox textBox_valor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_formaPagamento;
        private System.Windows.Forms.TextBox textBox_observacoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_salvarServico;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.DateTimePicker dateTimePicker_servico;
    }
}