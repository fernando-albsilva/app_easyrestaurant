
namespace view.viewProduto
{
    partial class Frm_produtoEdita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_produtoEdita));
            this.Pnl_principal = new System.Windows.Forms.Panel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_produto_custo = new System.Windows.Forms.TextBox();
            this.Lbl_Custo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_produto_valor = new System.Windows.Forms.TextBox();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_busca_produto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_produto_nome = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Produto = new System.Windows.Forms.Label();
            this.Pnl_principal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_principal
            // 
            this.Pnl_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_principal.BackColor = System.Drawing.Color.White;
            this.Pnl_principal.Controls.Add(this.btn_editar);
            this.Pnl_principal.Controls.Add(this.panel3);
            this.Pnl_principal.Controls.Add(this.panel2);
            this.Pnl_principal.Controls.Add(this.panel4);
            this.Pnl_principal.Controls.Add(this.Btn_busca_produto);
            this.Pnl_principal.Controls.Add(this.panel1);
            this.Pnl_principal.Controls.Add(this.Lbl_Produto);
            this.Pnl_principal.Location = new System.Drawing.Point(13, 13);
            this.Pnl_principal.Name = "Pnl_principal";
            this.Pnl_principal.Size = new System.Drawing.Size(644, 603);
            this.Pnl_principal.TabIndex = 0;
            this.Pnl_principal.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_principal_Paint);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_editar.Location = new System.Drawing.Point(36, 217);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(180, 46);
            this.btn_editar.TabIndex = 13;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_produto_custo);
            this.panel3.Controls.Add(this.Lbl_Custo);
            this.panel3.Location = new System.Drawing.Point(247, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 100);
            this.panel3.TabIndex = 12;
            // 
            // txt_produto_custo
            // 
            this.txt_produto_custo.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_produto_custo.Location = new System.Drawing.Point(164, 30);
            this.txt_produto_custo.Name = "txt_produto_custo";
            this.txt_produto_custo.Size = new System.Drawing.Size(170, 30);
            this.txt_produto_custo.TabIndex = 4;
            // 
            // Lbl_Custo
            // 
            this.Lbl_Custo.Font = new System.Drawing.Font("Arial", 15F);
            this.Lbl_Custo.Location = new System.Drawing.Point(16, 33);
            this.Lbl_Custo.Name = "Lbl_Custo";
            this.Lbl_Custo.Size = new System.Drawing.Size(147, 23);
            this.Lbl_Custo.TabIndex = 3;
            this.Lbl_Custo.Text = "Custo Unitário :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_produto_valor);
            this.panel2.Controls.Add(this.Lbl_Valor);
            this.panel2.Location = new System.Drawing.Point(247, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 100);
            this.panel2.TabIndex = 11;
            // 
            // txt_produto_valor
            // 
            this.txt_produto_valor.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_produto_valor.Location = new System.Drawing.Point(87, 32);
            this.txt_produto_valor.Name = "txt_produto_valor";
            this.txt_produto_valor.Size = new System.Drawing.Size(247, 30);
            this.txt_produto_valor.TabIndex = 3;
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.Font = new System.Drawing.Font("Arial", 15F);
            this.Lbl_Valor.Location = new System.Drawing.Point(16, 39);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(100, 23);
            this.Lbl_Valor.TabIndex = 2;
            this.Lbl_Valor.Text = "Valor :";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(247, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 100);
            this.panel4.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 15F);
            this.textBox1.Location = new System.Drawing.Point(87, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 30);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome :";
            // 
            // Btn_busca_produto
            // 
            this.Btn_busca_produto.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_busca_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_busca_produto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_busca_produto.Font = new System.Drawing.Font("Arial", 12F);
            this.Btn_busca_produto.Location = new System.Drawing.Point(36, 83);
            this.Btn_busca_produto.Name = "Btn_busca_produto";
            this.Btn_busca_produto.Size = new System.Drawing.Size(180, 46);
            this.Btn_busca_produto.TabIndex = 9;
            this.Btn_busca_produto.Text = "Buscar";
            this.Btn_busca_produto.UseVisualStyleBackColor = false;
            this.Btn_busca_produto.Click += new System.EventHandler(this.Btn_busca_produto_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_produto_nome);
            this.panel1.Controls.Add(this.Lbl_Nome);
            this.panel1.Location = new System.Drawing.Point(247, 83);
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
            this.Lbl_Produto.Location = new System.Drawing.Point(189, 24);
            this.Lbl_Produto.Name = "Lbl_Produto";
            this.Lbl_Produto.Size = new System.Drawing.Size(264, 37);
            this.Lbl_Produto.TabIndex = 0;
            this.Lbl_Produto.Text = "Produto Detalhado";
            // 
            // Frm_produtoEdita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(671, 628);
            this.Controls.Add(this.Pnl_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_produtoEdita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Produto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_produtoEdita_Load);
            this.Pnl_principal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_principal;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Produto;
        private System.Windows.Forms.TextBox txt_produto_nome;
        private System.Windows.Forms.Button Btn_busca_produto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_produto_custo;
        private System.Windows.Forms.Label Lbl_Custo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_produto_valor;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_editar;
    }
}