
namespace view.viewProduto
{
    partial class Frm_produtoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_produtoCadastro));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_produto_quantidade = new System.Windows.Forms.TextBox();
            this.Lbl_Quantidade = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_produto_valor = new System.Windows.Forms.TextBox();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_produto_nome = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Produto = new System.Windows.Forms.Label();
            this.Btn_inclui_produto = new System.Windows.Forms.Button();
            this.Pnl_principal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_principal.BackColor = System.Drawing.Color.White;
            this.Pnl_principal.Controls.Add(this.Btn_inclui_produto);
            this.Pnl_principal.Controls.Add(this.panel3);
            this.Pnl_principal.Controls.Add(this.panel2);
            this.Pnl_principal.Controls.Add(this.panel1);
            this.Pnl_principal.Controls.Add(this.Lbl_Produto);
            this.Pnl_principal.Location = new System.Drawing.Point(13, 13);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(644, 603);
            this.Pnl_principal.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_produto_quantidade);
            this.panel3.Controls.Add(this.Lbl_Quantidade);
            this.panel3.Location = new System.Drawing.Point(144, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 100);
            this.panel3.TabIndex = 6;
            // 
            // txt_produto_quantidade
            // 
            this.txt_produto_quantidade.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_produto_quantidade.Location = new System.Drawing.Point(142, 26);
            this.txt_produto_quantidade.Name = "txt_produto_quantidade";
            this.txt_produto_quantidade.Size = new System.Drawing.Size(192, 30);
            this.txt_produto_quantidade.TabIndex = 4;
            // 
            // Lbl_Quantidade
            // 
            this.Lbl_Quantidade.Font = new System.Drawing.Font("Arial", 15F);
            this.Lbl_Quantidade.Location = new System.Drawing.Point(16, 33);
            this.Lbl_Quantidade.Name = "Lbl_Quantidade";
            this.Lbl_Quantidade.Size = new System.Drawing.Size(129, 23);
            this.Lbl_Quantidade.TabIndex = 3;
            this.Lbl_Quantidade.Text = "Quantidade :";
            this.Lbl_Quantidade.Click += new System.EventHandler(this.Lbl_Quantidade_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_produto_valor);
            this.panel2.Controls.Add(this.Lbl_Valor);
            this.panel2.Location = new System.Drawing.Point(144, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 100);
            this.panel2.TabIndex = 5;
            // 
            // txt_produto_valor
            // 
            this.txt_produto_valor.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_produto_valor.Location = new System.Drawing.Point(87, 20);
            this.txt_produto_valor.Name = "txt_produto_valor";
            this.txt_produto_valor.Size = new System.Drawing.Size(247, 30);
            this.txt_produto_valor.TabIndex = 3;
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.Font = new System.Drawing.Font("Arial", 15F);
            this.Lbl_Valor.Location = new System.Drawing.Point(16, 27);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(100, 23);
            this.Lbl_Valor.TabIndex = 2;
            this.Lbl_Valor.Text = "Valor :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_produto_nome);
            this.panel1.Controls.Add(this.Lbl_Nome);
            this.panel1.Location = new System.Drawing.Point(144, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 100);
            this.panel1.TabIndex = 4;
            // 
            // txt_produto_nome
            // 
            this.txt_produto_nome.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_produto_nome.Location = new System.Drawing.Point(87, 38);
            this.txt_produto_nome.Name = "txt_produto_nome";
            this.txt_produto_nome.Size = new System.Drawing.Size(247, 30);
            this.txt_produto_nome.TabIndex = 2;
            this.txt_produto_nome.TextChanged += new System.EventHandler(this.Txt_produto_nome_TextChanged);
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
            // Lbl_Produto
            // 
            this.Lbl_Produto.Font = new System.Drawing.Font("Arial", 20F);
            this.Lbl_Produto.Location = new System.Drawing.Point(198, 49);
            this.Lbl_Produto.Name = "Lbl_Produto";
            this.Lbl_Produto.Size = new System.Drawing.Size(220, 37);
            this.Lbl_Produto.TabIndex = 0;
            this.Lbl_Produto.Text = "Inclusão Produto";
            // 
            // Btn_inclui_produto
            // 
            this.Btn_inclui_produto.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_inclui_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_inclui_produto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_inclui_produto.Font = new System.Drawing.Font("Arial", 12F);
            this.Btn_inclui_produto.Location = new System.Drawing.Point(232, 513);
            this.Btn_inclui_produto.Name = "Btn_inclui_produto";
            this.Btn_inclui_produto.Size = new System.Drawing.Size(180, 46);
            this.Btn_inclui_produto.TabIndex = 9;
            this.Btn_inclui_produto.Text = "Incluir Produto";
            this.Btn_inclui_produto.UseVisualStyleBackColor = false;
            this.Btn_inclui_produto.Click += new System.EventHandler(this.Btn_inclui_produto_Click);
            // 
            // Frm_produtoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(671, 628);
            this.Controls.Add(this.Pnl_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_produtoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir Produto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_produtoCadastro_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Quantidade;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Label Lbl_Produto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_produto_nome;
        private System.Windows.Forms.TextBox txt_produto_valor;
        private System.Windows.Forms.TextBox txt_produto_quantidade;
        private System.Windows.Forms.Button Btn_inclui_produto;
    }



}