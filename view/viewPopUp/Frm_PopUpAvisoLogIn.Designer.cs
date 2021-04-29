
namespace view.viewPopUp
{
    partial class Frm_PopUpAvisoLogIn
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
            this.Pnl_center = new System.Windows.Forms.Panel();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Lbl_informacaoAviso = new System.Windows.Forms.Label();
            this.Pnl_center.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_center
            // 
            this.Pnl_center.BackColor = System.Drawing.Color.White;
            this.Pnl_center.Controls.Add(this.Btn_Ok);
            this.Pnl_center.Controls.Add(this.Lbl_informacaoAviso);
            this.Pnl_center.Location = new System.Drawing.Point(13, 13);
            this.Pnl_center.Name = "Pnl_center";
            this.Pnl_center.Size = new System.Drawing.Size(553, 252);
            this.Pnl_center.TabIndex = 0;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.BackColor = System.Drawing.Color.LightSalmon;
            this.Btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Ok.Font = new System.Drawing.Font("Arial", 15F);
            this.Btn_Ok.Location = new System.Drawing.Point(212, 144);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(120, 46);
            this.Btn_Ok.TabIndex = 3;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = false;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Lbl_informacaoAviso
            // 
            this.Lbl_informacaoAviso.AutoSize = true;
            this.Lbl_informacaoAviso.Font = new System.Drawing.Font("Arial", 18F);
            this.Lbl_informacaoAviso.Location = new System.Drawing.Point(92, 74);
            this.Lbl_informacaoAviso.Name = "Lbl_informacaoAviso";
            this.Lbl_informacaoAviso.Size = new System.Drawing.Size(407, 27);
            this.Lbl_informacaoAviso.TabIndex = 1;
            this.Lbl_informacaoAviso.Text = "Atenção, usuário ou senha inválidos!";
            this.Lbl_informacaoAviso.Click += new System.EventHandler(this.Lbl_informacaoSair_Click);
            // 
            // Frm_PopUpAvisoLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(578, 277);
            this.Controls.Add(this.Pnl_center);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_PopUpAvisoLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atenção:";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_PopUpAvisoLogIn_Load);
            this.Pnl_center.ResumeLayout(false);
            this.Pnl_center.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_center;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Label Lbl_informacaoAviso;

    


    }
}