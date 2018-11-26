namespace WindowsFormsApp1
{
    partial class LoginForm
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Logar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_login.BackColor = System.Drawing.Color.Black;
            this.textBox_login.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login.ForeColor = System.Drawing.Color.White;
            this.textBox_login.Location = new System.Drawing.Point(96, 299);
            this.textBox_login.MaxLength = 15;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(138, 29);
            this.textBox_login.TabIndex = 1;
            this.textBox_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecharEpularCampos);
            // 
            // textBox_senha
            // 
            this.textBox_senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_senha.BackColor = System.Drawing.Color.Black;
            this.textBox_senha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_senha.ForeColor = System.Drawing.Color.White;
            this.textBox_senha.Location = new System.Drawing.Point(340, 299);
            this.textBox_senha.MaxLength = 15;
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.PasswordChar = '*';
            this.textBox_senha.Size = new System.Drawing.Size(137, 29);
            this.textBox_senha.TabIndex = 2;
            this.textBox_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecharEpularCampos);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "SENHA";
            // 
            // button_Logar
            // 
            this.button_Logar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Logar.BackColor = System.Drawing.Color.Black;
            this.button_Logar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logar.ForeColor = System.Drawing.Color.White;
            this.button_Logar.Location = new System.Drawing.Point(502, 290);
            this.button_Logar.Name = "button_Logar";
            this.button_Logar.Size = new System.Drawing.Size(95, 46);
            this.button_Logar.TabIndex = 3;
            this.button_Logar.Text = "LOGAR";
            this.button_Logar.UseVisualStyleBackColor = false;
            this.button_Logar.Click += new System.EventHandler(this.button_Logar_Click);
            this.button_Logar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogarComEnter);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(639, 340);
            this.Controls.Add(this.button_Logar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.textBox_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Logar;
    }
}