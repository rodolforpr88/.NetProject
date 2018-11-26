namespace WindowsFormsApp1
{
    partial class CadastrarUsuarioForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.btn_CadastrarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Login";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Login.Location = new System.Drawing.Point(124, 46);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(192, 26);
            this.textBox_Login.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Senha";
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Senha.Location = new System.Drawing.Point(124, 111);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.PasswordChar = '*';
            this.textBox_Senha.Size = new System.Drawing.Size(192, 26);
            this.textBox_Senha.TabIndex = 2;
            // 
            // btn_CadastrarUsuario
            // 
            this.btn_CadastrarUsuario.FlatAppearance.BorderSize = 3;
            this.btn_CadastrarUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadastrarUsuario.Location = new System.Drawing.Point(68, 188);
            this.btn_CadastrarUsuario.Name = "btn_CadastrarUsuario";
            this.btn_CadastrarUsuario.Size = new System.Drawing.Size(248, 60);
            this.btn_CadastrarUsuario.TabIndex = 3;
            this.btn_CadastrarUsuario.Text = "CADASTRAR";
            this.btn_CadastrarUsuario.UseVisualStyleBackColor = true;
            this.btn_CadastrarUsuario.Click += new System.EventHandler(this.btn_CadastrarUsuario_Click);
            // 
            // CadastrarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 313);
            this.Controls.Add(this.btn_CadastrarUsuario);
            this.Controls.Add(this.textBox_Senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastrarUsuarioForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProntoVet - Tela Cadastro de Usuário";
            this.Load += new System.EventHandler(this.CadastrarUsuarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Senha;
        private System.Windows.Forms.Button btn_CadastrarUsuario;
    }
}