
namespace view.viewGarcom
{
    partial class Frm_garcomCadastra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_garcomCadastra));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.Btn_incluiGarcom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_garcomNome = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_garçom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_garcomCpf = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.Pnl_principal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_principal.BackColor = System.Drawing.Color.White;
            this.Pnl_principal.Controls.Add(this.panel2);
            this.Pnl_principal.Controls.Add(this.Btn_incluiGarcom);
            this.Pnl_principal.Controls.Add(this.panel1);
            this.Pnl_principal.Controls.Add(this.lbl_garçom);
            this.Pnl_principal.Location = new System.Drawing.Point(13, 13);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(644, 603);
            this.Pnl_principal.TabIndex = 0;
            // 
            // Btn_incluiGarcom
            // 
            this.Btn_incluiGarcom.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_incluiGarcom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_incluiGarcom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_incluiGarcom.Font = new System.Drawing.Font("Arial", 12F);
            this.Btn_incluiGarcom.Location = new System.Drawing.Point(231, 507);
            this.Btn_incluiGarcom.Name = "Btn_incluiGarcom";
            this.Btn_incluiGarcom.Size = new System.Drawing.Size(180, 46);
            this.Btn_incluiGarcom.TabIndex = 9;
            this.Btn_incluiGarcom.Text = "Incluir Garcom";
            this.Btn_incluiGarcom.UseVisualStyleBackColor = false;
            this.Btn_incluiGarcom.Click += new System.EventHandler(this.Btn_incluiGarcom_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_garcomNome);
            this.panel1.Controls.Add(this.Lbl_Nome);
            this.panel1.Location = new System.Drawing.Point(143, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 100);
            this.panel1.TabIndex = 4;
            // 
            // txt_garcomNome
            // 
            this.txt_garcomNome.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_garcomNome.Location = new System.Drawing.Point(87, 38);
            this.txt_garcomNome.Name = "txt_garcomNome";
            this.txt_garcomNome.Size = new System.Drawing.Size(247, 30);
            this.txt_garcomNome.TabIndex = 2;
            this.txt_garcomNome.TextChanged += new System.EventHandler(this.Txt_produto_nome_TextChanged);
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.Font = new System.Drawing.Font("Arial", 15F);
            this.Lbl_Nome.Location = new System.Drawing.Point(16, 41);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(100, 23);
            this.Lbl_Nome.TabIndex = 1;
            this.Lbl_Nome.Text = "Nome :";
            this.Lbl_Nome.Click += new System.EventHandler(this.Lbl_Nome_Click);
            // 
            // lbl_garçom
            // 
            this.lbl_garçom.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_garçom.Location = new System.Drawing.Point(201, 43);
            this.lbl_garçom.Name = "lbl_garçom";
            this.lbl_garçom.Size = new System.Drawing.Size(264, 37);
            this.lbl_garçom.TabIndex = 0;
            this.lbl_garçom.Text = "Cadastro Garçom";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_garcomCpf);
            this.panel2.Controls.Add(this.lbl_cpf);
            this.panel2.Location = new System.Drawing.Point(143, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 100);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_garcomCpf
            // 
            this.txt_garcomCpf.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_garcomCpf.Location = new System.Drawing.Point(87, 38);
            this.txt_garcomCpf.Name = "txt_garcomCpf";
            this.txt_garcomCpf.Size = new System.Drawing.Size(247, 30);
            this.txt_garcomCpf.TabIndex = 2;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.Font = new System.Drawing.Font("Arial", 15F);
            this.lbl_cpf.Location = new System.Drawing.Point(16, 41);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(100, 23);
            this.lbl_cpf.TabIndex = 1;
            this.lbl_cpf.Text = "CPF :";
            this.lbl_cpf.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_garcomCadastra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(671, 628);
            this.Controls.Add(this.Pnl_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_garcomCadastra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Garcom";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_garcomCadastra_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_garçom;
        private System.Windows.Forms.TextBox txt_garcomNome;
        private System.Windows.Forms.Button Btn_incluiGarcom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_garcomCpf;
        private System.Windows.Forms.Label lbl_cpf;
    }
}