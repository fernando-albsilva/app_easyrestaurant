
namespace view.viewPopUp
{
    partial class Frm_PopUpSair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PopUpSair));
            this.Pnl_center = new System.Windows.Forms.Panel();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_sair = new System.Windows.Forms.Button();
            this.Lbl_informacaoSair = new System.Windows.Forms.Label();
            this.Lbl_sairMensagem = new System.Windows.Forms.Label();
            this.Pnl_center.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_center
            // 
            this.Pnl_center.BackColor = System.Drawing.Color.White;
            this.Pnl_center.Controls.Add(this.Btn_cancelar);
            this.Pnl_center.Controls.Add(this.Btn_sair);
            this.Pnl_center.Controls.Add(this.Lbl_informacaoSair);
            this.Pnl_center.Controls.Add(this.Lbl_sairMensagem);
            this.Pnl_center.Location = new System.Drawing.Point(13, 13);
            this.Pnl_center.Name = "Pnl_center";
            this.Pnl_center.Size = new System.Drawing.Size(553, 252);
            this.Pnl_center.TabIndex = 0;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_cancelar.Font = new System.Drawing.Font("Arial", 15F);
            this.Btn_cancelar.Location = new System.Drawing.Point(330, 165);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(120, 46);
            this.Btn_cancelar.TabIndex = 3;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_sair
            // 
            this.Btn_sair.BackColor = System.Drawing.Color.GreenYellow;
            this.Btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_sair.Font = new System.Drawing.Font("Arial", 15F);
            this.Btn_sair.Location = new System.Drawing.Point(93, 165);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(120, 46);
            this.Btn_sair.TabIndex = 2;
            this.Btn_sair.Text = "Sair";
            this.Btn_sair.UseVisualStyleBackColor = false;
            this.Btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // Lbl_informacaoSair
            // 
            this.Lbl_informacaoSair.AutoSize = true;
            this.Lbl_informacaoSair.Font = new System.Drawing.Font("Arial", 18F);
            this.Lbl_informacaoSair.Location = new System.Drawing.Point(32, 62);
            this.Lbl_informacaoSair.Name = "Lbl_informacaoSair";
            this.Lbl_informacaoSair.Size = new System.Drawing.Size(498, 27);
            this.Lbl_informacaoSair.TabIndex = 1;
            this.Lbl_informacaoSair.Text = "Todo conteudo de mesas ativas será perdido!";
            // 
            // Lbl_sairMensagem
            // 
            this.Lbl_sairMensagem.Font = new System.Drawing.Font("Arial", 15F);
            this.Lbl_sairMensagem.Location = new System.Drawing.Point(143, 106);
            this.Lbl_sairMensagem.Name = "Lbl_sairMensagem";
            this.Lbl_sairMensagem.Size = new System.Drawing.Size(387, 38);
            this.Lbl_sairMensagem.TabIndex = 0;
            this.Lbl_sairMensagem.Text = "Tem Certeza que deseja Sair?";
            // 
            // Frm_PopUpSair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(578, 277);
            this.Controls.Add(this.Pnl_center);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PopUpSair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atenção:";
            this.Pnl_center.ResumeLayout(false);
            this.Pnl_center.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_center;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_sair;
        private System.Windows.Forms.Label Lbl_informacaoSair;
        private System.Windows.Forms.Label Lbl_sairMensagem;
    }
}