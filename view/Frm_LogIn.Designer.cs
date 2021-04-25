
namespace view
{
    partial class Frm_LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LogIn));
            this.Btn_enviar = new System.Windows.Forms.Button();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.Pnl_container_login = new System.Windows.Forms.Panel();
            this.Lbl_login_login = new System.Windows.Forms.Label();
            this.Lbl_logIn_user = new System.Windows.Forms.Label();
            this.Lbl_imagem_login = new System.Windows.Forms.Label();
            this.Pnl_container_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_enviar
            // 
            this.Btn_enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.Btn_enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_enviar.FlatAppearance.BorderSize = 0;
            this.Btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_enviar.Font = new System.Drawing.Font("Arial", 20F);
            this.Btn_enviar.ForeColor = System.Drawing.Color.White;
            this.Btn_enviar.Location = new System.Drawing.Point(0, 431);
            this.Btn_enviar.Name = "Btn_enviar";
            this.Btn_enviar.Size = new System.Drawing.Size(316, 47);
            this.Btn_enviar.TabIndex = 1;
            this.Btn_enviar.Text = "Enviar";
            this.Btn_enviar.UseVisualStyleBackColor = false;
            this.Btn_enviar.Click += new System.EventHandler(this.Lbl_enviar_Click);
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.BackColor = System.Drawing.SystemColors.InfoText;
            this.Txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.Txt_usuario.Location = new System.Drawing.Point(0, 303);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(316, 31);
            this.Txt_usuario.TabIndex = 2;
            this.Txt_usuario.Text = "Username";
            this.Txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_usuario.Leave += new System.EventHandler(this.Txt_usuario_Leave);
            this.Txt_usuario.MouseHover += new System.EventHandler(this.Txt_usuario_MouseHover);
            // 
            // Txt_senha
            // 
            this.Txt_senha.BackColor = System.Drawing.SystemColors.WindowText;
            this.Txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_senha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Txt_senha.Location = new System.Drawing.Point(0, 366);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.PasswordChar = '*';
            this.Txt_senha.Size = new System.Drawing.Size(316, 31);
            this.Txt_senha.TabIndex = 4;
            this.Txt_senha.Text = "Senha";
            this.Txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_senha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_senha_MouseClick);
            this.Txt_senha.Leave += new System.EventHandler(this.Txt_senha_Leave);
            // 
            // Pnl_container_login
            // 
            this.Pnl_container_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pnl_container_login.BackColor = System.Drawing.SystemColors.Window;
            this.Pnl_container_login.Controls.Add(this.Lbl_login_login);
            this.Pnl_container_login.Controls.Add(this.Lbl_logIn_user);
            this.Pnl_container_login.Controls.Add(this.Lbl_imagem_login);
            this.Pnl_container_login.Controls.Add(this.Txt_usuario);
            this.Pnl_container_login.Controls.Add(this.Txt_senha);
            this.Pnl_container_login.Controls.Add(this.Btn_enviar);
            this.Pnl_container_login.Location = new System.Drawing.Point(295, 24);
            this.Pnl_container_login.Name = "Pnl_container_login";
            this.Pnl_container_login.Size = new System.Drawing.Size(319, 554);
            this.Pnl_container_login.TabIndex = 5;
            // 
            // Lbl_login_login
            // 
            this.Lbl_login_login.AutoSize = true;
            this.Lbl_login_login.Font = new System.Drawing.Font("Arial", 38F);
            this.Lbl_login_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.Lbl_login_login.Location = new System.Drawing.Point(145, 226);
            this.Lbl_login_login.Name = "Lbl_login_login";
            this.Lbl_login_login.Size = new System.Drawing.Size(183, 58);
            this.Lbl_login_login.TabIndex = 7;
            this.Lbl_login_login.Text = "LOGIN";
            // 
            // Lbl_logIn_user
            // 
            this.Lbl_logIn_user.AutoSize = true;
            this.Lbl_logIn_user.Font = new System.Drawing.Font("Arial", 38F);
            this.Lbl_logIn_user.Location = new System.Drawing.Point(-7, 226);
            this.Lbl_logIn_user.Name = "Lbl_logIn_user";
            this.Lbl_logIn_user.Size = new System.Drawing.Size(167, 58);
            this.Lbl_logIn_user.TabIndex = 6;
            this.Lbl_logIn_user.Text = "USER";
            // 
            // Lbl_imagem_login
            // 
            this.Lbl_imagem_login.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_imagem_login.Image")));
            this.Lbl_imagem_login.Location = new System.Drawing.Point(-2, 0);
            this.Lbl_imagem_login.Name = "Lbl_imagem_login";
            this.Lbl_imagem_login.Size = new System.Drawing.Size(322, 200);
            this.Lbl_imagem_login.TabIndex = 5;
            // 
            // Frm_LogIn
            // 
            this.AcceptButton = this.Btn_enviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(926, 590);
            this.Controls.Add(this.Pnl_container_login);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_LogIn";
            this.Text = "LogIn";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.Pnl_container_login.ResumeLayout(false);
            this.Pnl_container_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_enviar;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TextBox Txt_senha;
        private System.Windows.Forms.Panel Pnl_container_login;
        private System.Windows.Forms.Label Lbl_imagem_login;
        private System.Windows.Forms.Label Lbl_logIn_user;
        private System.Windows.Forms.Label Lbl_login_login;
    }
}

