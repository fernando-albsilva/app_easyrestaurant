
namespace view.viewProduto
{
    partial class Frm_produtoExclui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_produtoExclui));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.btn_excluirProduto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_informacao = new System.Windows.Forms.Label();
            this.lbl_produtoNome = new System.Windows.Forms.Label();
            this.Lbl_Custo = new System.Windows.Forms.Label();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_produto_nome = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Produto = new System.Windows.Forms.Label();
            this.Pnl_principal.SuspendLayout();
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
            this.Pnl_principal.Controls.Add(this.btn_excluirProduto);
            this.Pnl_principal.Controls.Add(this.panel2);
            this.Pnl_principal.Controls.Add(this.panel1);
            this.Pnl_principal.Controls.Add(this.Lbl_Produto);
            this.Pnl_principal.Location = new System.Drawing.Point(13, 13);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(644, 603);
            this.Pnl_principal.TabIndex = 0;
            // 
            // btn_excluirProduto
            // 
            this.btn_excluirProduto.BackColor = System.Drawing.Color.Salmon;
            this.btn_excluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluirProduto.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_excluirProduto.Location = new System.Drawing.Point(232, 231);
            this.btn_excluirProduto.Name = "btn_excluirProduto";
            this.btn_excluirProduto.Size = new System.Drawing.Size(180, 46);
            this.btn_excluirProduto.TabIndex = 9;
            this.btn_excluirProduto.Text = "Excluir";
            this.btn_excluirProduto.UseVisualStyleBackColor = false;
            this.btn_excluirProduto.Click += new System.EventHandler(this.btn_excluirProduto_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_informacao);
            this.panel2.Controls.Add(this.lbl_produtoNome);
            this.panel2.Controls.Add(this.Lbl_Custo);
            this.panel2.Controls.Add(this.Lbl_Valor);
            this.panel2.Location = new System.Drawing.Point(144, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 267);
            this.panel2.TabIndex = 5;
            // 
            // lbl_informacao
            // 
            this.lbl_informacao.Font = new System.Drawing.Font("Arial", 15F);
            this.lbl_informacao.Location = new System.Drawing.Point(111, 27);
            this.lbl_informacao.Name = "lbl_informacao";
            this.lbl_informacao.Size = new System.Drawing.Size(113, 23);
            this.lbl_informacao.TabIndex = 5;
            this.lbl_informacao.Text = "Informação";
            // 
            // lbl_produtoNome
            // 
            this.lbl_produtoNome.Font = new System.Drawing.Font("Arial", 15F);
            this.lbl_produtoNome.Location = new System.Drawing.Point(16, 107);
            this.lbl_produtoNome.Name = "lbl_produtoNome";
            this.lbl_produtoNome.Size = new System.Drawing.Size(100, 23);
            this.lbl_produtoNome.TabIndex = 4;
            this.lbl_produtoNome.Text = "Nome :";
            // 
            // Lbl_Custo
            // 
            this.Lbl_Custo.Font = new System.Drawing.Font("Arial", 15F);
            this.Lbl_Custo.Location = new System.Drawing.Point(16, 213);
            this.Lbl_Custo.Name = "Lbl_Custo";
            this.Lbl_Custo.Size = new System.Drawing.Size(147, 23);
            this.Lbl_Custo.TabIndex = 3;
            this.Lbl_Custo.Text = "Custo Unitário :";
            this.Lbl_Custo.Click += new System.EventHandler(this.Lbl_Quantidade_Click);
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.Font = new System.Drawing.Font("Arial", 15F);
            this.Lbl_Valor.Location = new System.Drawing.Point(16, 161);
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
            this.panel1.Location = new System.Drawing.Point(144, 111);
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
            this.Lbl_Produto.Location = new System.Drawing.Point(201, 43);
            this.Lbl_Produto.Name = "Lbl_Produto";
            this.Lbl_Produto.Size = new System.Drawing.Size(264, 37);
            this.Lbl_Produto.TabIndex = 0;
            this.Lbl_Produto.Text = "Produto Exclusão";
            // 
            // Frm_produtoExclui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(671, 628);
            this.Controls.Add(this.Pnl_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_produtoExclui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhar Produto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_produtoExclui_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Custo;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Label Lbl_Produto;
        private System.Windows.Forms.TextBox txt_produto_nome;
        private System.Windows.Forms.Button btn_excluirProduto;
        private System.Windows.Forms.Label lbl_informacao;
        private System.Windows.Forms.Label lbl_produtoNome;

    }

       
    
}