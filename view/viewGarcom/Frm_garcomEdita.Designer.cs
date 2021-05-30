
namespace view.viewGarcom
{
    partial class Frm_garcomEdita
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
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_cpf_garcom = new System.Windows.Forms.Panel();
            this.txt_garcom_cpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_editarGarcom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_garcom_novo_nome = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_garçom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nome_garcom_info = new System.Windows.Forms.Label();
            this.Pnl_principal.SuspendLayout();
            this.txt_cpf_garcom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_principal.BackColor = System.Drawing.Color.White;
            this.Pnl_principal.Controls.Add(this.btn_buscar);
            this.Pnl_principal.Controls.Add(this.txt_cpf_garcom);
            this.Pnl_principal.Controls.Add(this.Btn_editarGarcom);
            this.Pnl_principal.Controls.Add(this.panel1);
            this.Pnl_principal.Controls.Add(this.lbl_garçom);
            this.Pnl_principal.Location = new System.Drawing.Point(13, 13);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(644, 603);
            this.Pnl_principal.TabIndex = 0;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(34, 135);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(180, 46);
            this.btn_buscar.TabIndex = 11;
            this.btn_buscar.Text = "Buscar Garçom";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_cpf_garcom
            // 
            this.txt_cpf_garcom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cpf_garcom.Controls.Add(this.lbl_nome_garcom_info);
            this.txt_cpf_garcom.Controls.Add(this.label2);
            this.txt_cpf_garcom.Controls.Add(this.txt_garcom_cpf);
            this.txt_cpf_garcom.Controls.Add(this.label1);
            this.txt_cpf_garcom.Location = new System.Drawing.Point(230, 135);
            this.txt_cpf_garcom.Name = "txt_cpf_garcom";
            this.txt_cpf_garcom.Size = new System.Drawing.Size(357, 208);
            this.txt_cpf_garcom.TabIndex = 10;
            // 
            // txt_garcom_cpf
            // 
            this.txt_garcom_cpf.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_garcom_cpf.Location = new System.Drawing.Point(87, 38);
            this.txt_garcom_cpf.Name = "txt_garcom_cpf";
            this.txt_garcom_cpf.Size = new System.Drawing.Size(247, 30);
            this.txt_garcom_cpf.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_editarGarcom
            // 
            this.Btn_editarGarcom.BackColor = System.Drawing.Color.LemonChiffon;
            this.Btn_editarGarcom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_editarGarcom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_editarGarcom.Font = new System.Drawing.Font("Arial", 12F);
            this.Btn_editarGarcom.Location = new System.Drawing.Point(34, 381);
            this.Btn_editarGarcom.Name = "Btn_editarGarcom";
            this.Btn_editarGarcom.Size = new System.Drawing.Size(180, 46);
            this.Btn_editarGarcom.TabIndex = 9;
            this.Btn_editarGarcom.Text = "Editar Garcom";
            this.Btn_editarGarcom.UseVisualStyleBackColor = false;
            this.Btn_editarGarcom.Click += new System.EventHandler(this.Btn_editarGarcom_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_garcom_novo_nome);
            this.panel1.Controls.Add(this.Lbl_Nome);
            this.panel1.Location = new System.Drawing.Point(230, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 100);
            this.panel1.TabIndex = 4;
            // 
            // txt_garcom_novo_nome
            // 
            this.txt_garcom_novo_nome.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_garcom_novo_nome.Location = new System.Drawing.Point(87, 38);
            this.txt_garcom_novo_nome.Name = "txt_garcom_novo_nome";
            this.txt_garcom_novo_nome.Size = new System.Drawing.Size(247, 30);
            this.txt_garcom_novo_nome.TabIndex = 2;
            this.txt_garcom_novo_nome.TextChanged += new System.EventHandler(this.Txt_produto_nome_TextChanged);
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.Font = new System.Drawing.Font("Arial", 15F);
            this.Lbl_Nome.Location = new System.Drawing.Point(14, 45);
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
            this.lbl_garçom.Text = "Editar  Garçom";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 15F);
            this.label2.Location = new System.Drawing.Point(14, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_nome_garcom_info
            // 
            this.lbl_nome_garcom_info.Font = new System.Drawing.Font("Arial", 15F);
            this.lbl_nome_garcom_info.Location = new System.Drawing.Point(83, 123);
            this.lbl_nome_garcom_info.Name = "lbl_nome_garcom_info";
            this.lbl_nome_garcom_info.Size = new System.Drawing.Size(100, 23);
            this.lbl_nome_garcom_info.TabIndex = 4;
            // 
            // Frm_garcomEdita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(671, 628);
            this.Controls.Add(this.Pnl_principal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_garcomEdita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Garcom";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_garcomEdita_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.txt_cpf_garcom.ResumeLayout(false);
            this.txt_cpf_garcom.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_garçom;
        private System.Windows.Forms.TextBox txt_garcom_novo_nome;
        private System.Windows.Forms.Button Btn_editarGarcom;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Panel txt_cpf_garcom;
        private System.Windows.Forms.TextBox txt_garcom_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nome_garcom_info;
    }
}