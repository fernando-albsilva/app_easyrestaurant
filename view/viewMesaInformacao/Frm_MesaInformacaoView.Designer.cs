
namespace view.viewMesaInformacao
{
    partial class Frm_MesaInformacaoView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MesaInformacaoView));
            this.Lbl_mesaNumero = new System.Windows.Forms.Label();
            this.Lbl_nomeCLiente = new System.Windows.Forms.Label();
            this.Lbl_horaDeInicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_total_com_10porcento = new System.Windows.Forms.Label();
            this.lbl_valor_10porcento = new System.Windows.Forms.Label();
            this.lbl_valor_conta = new System.Windows.Forms.Label();
            this.lbl_total_conta = new System.Windows.Forms.Label();
            this.Lbl_10porcento = new System.Windows.Forms.Label();
            this.Lbl_total_conta_10porcento = new System.Windows.Forms.Label();
            this.Pnl_conta_detalhada = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lbl_conta_detalhe = new System.Windows.Forms.Label();
            this.Pnl_center = new System.Windows.Forms.Panel();
            this.Lbl_nomeGarcom = new System.Windows.Forms.Label();
            this.Btn_inclui_produto = new System.Windows.Forms.Button();
            this.Pnl_east = new System.Windows.Forms.Panel();
            this.Btn_finaliza_mesa = new System.Windows.Forms.Button();
            this.Btn_inicia_mesa = new System.Windows.Forms.Button();
            this.Txt_garcom = new System.Windows.Forms.TextBox();
            this.Lbl_nome_cliente = new System.Windows.Forms.Label();
            this.Lbl_garcom = new System.Windows.Forms.Label();
            this.Txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dt_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_excluir_item = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Pnl_conta_detalhada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Pnl_center.SuspendLayout();
            this.Pnl_east.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_mesaNumero
            // 
            this.Lbl_mesaNumero.AutoSize = true;
            this.Lbl_mesaNumero.Font = new System.Drawing.Font("Arial", 12F);
            this.Lbl_mesaNumero.Location = new System.Drawing.Point(26, 42);
            this.Lbl_mesaNumero.Name = "Lbl_mesaNumero";
            this.Lbl_mesaNumero.Size = new System.Drawing.Size(114, 18);
            this.Lbl_mesaNumero.TabIndex = 0;
            this.Lbl_mesaNumero.Text = "Numero mesa :";
            // 
            // Lbl_nomeCLiente
            // 
            this.Lbl_nomeCLiente.AutoSize = true;
            this.Lbl_nomeCLiente.Font = new System.Drawing.Font("Arial", 12F);
            this.Lbl_nomeCLiente.Location = new System.Drawing.Point(27, 111);
            this.Lbl_nomeCLiente.Name = "Lbl_nomeCLiente";
            this.Lbl_nomeCLiente.Size = new System.Drawing.Size(129, 18);
            this.Lbl_nomeCLiente.TabIndex = 1;
            this.Lbl_nomeCLiente.Text = "Nome do cliente :";
            // 
            // Lbl_horaDeInicio
            // 
            this.Lbl_horaDeInicio.AutoSize = true;
            this.Lbl_horaDeInicio.Font = new System.Drawing.Font("Arial", 12F);
            this.Lbl_horaDeInicio.Location = new System.Drawing.Point(27, 179);
            this.Lbl_horaDeInicio.Name = "Lbl_horaDeInicio";
            this.Lbl_horaDeInicio.Size = new System.Drawing.Size(113, 18);
            this.Lbl_horaDeInicio.TabIndex = 2;
            this.Lbl_horaDeInicio.Text = "Hora de inicio :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Pnl_center);
            this.panel1.Controls.Add(this.Pnl_east);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 604);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_total_com_10porcento);
            this.panel2.Controls.Add(this.lbl_valor_10porcento);
            this.panel2.Controls.Add(this.lbl_valor_conta);
            this.panel2.Controls.Add(this.lbl_total_conta);
            this.panel2.Controls.Add(this.Lbl_10porcento);
            this.panel2.Controls.Add(this.Lbl_total_conta_10porcento);
            this.panel2.Controls.Add(this.Pnl_conta_detalhada);
            this.panel2.Controls.Add(this.Lbl_conta_detalhe);
            this.panel2.Location = new System.Drawing.Point(647, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 575);
            this.panel2.TabIndex = 10;
            // 
            // lbl_total_com_10porcento
            // 
            this.lbl_total_com_10porcento.AutoSize = true;
            this.lbl_total_com_10porcento.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_total_com_10porcento.Location = new System.Drawing.Point(170, 541);
            this.lbl_total_com_10porcento.Name = "lbl_total_com_10porcento";
            this.lbl_total_com_10porcento.Size = new System.Drawing.Size(72, 18);
            this.lbl_total_com_10porcento.TabIndex = 16;
            this.lbl_total_com_10porcento.Text = "R$ 00.00";
            // 
            // lbl_valor_10porcento
            // 
            this.lbl_valor_10porcento.AutoSize = true;
            this.lbl_valor_10porcento.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_valor_10porcento.Location = new System.Drawing.Point(72, 514);
            this.lbl_valor_10porcento.Name = "lbl_valor_10porcento";
            this.lbl_valor_10porcento.Size = new System.Drawing.Size(72, 18);
            this.lbl_valor_10porcento.TabIndex = 15;
            this.lbl_valor_10porcento.Text = "R$ 00.00";
            // 
            // lbl_valor_conta
            // 
            this.lbl_valor_conta.AutoSize = true;
            this.lbl_valor_conta.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_valor_conta.Location = new System.Drawing.Point(118, 480);
            this.lbl_valor_conta.Name = "lbl_valor_conta";
            this.lbl_valor_conta.Size = new System.Drawing.Size(72, 18);
            this.lbl_valor_conta.TabIndex = 14;
            this.lbl_valor_conta.Text = "R$ 00.00";
            // 
            // lbl_total_conta
            // 
            this.lbl_total_conta.AutoSize = true;
            this.lbl_total_conta.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_total_conta.Location = new System.Drawing.Point(18, 480);
            this.lbl_total_conta.Name = "lbl_total_conta";
            this.lbl_total_conta.Size = new System.Drawing.Size(94, 18);
            this.lbl_total_conta.TabIndex = 13;
            this.lbl_total_conta.Text = "Total Conta :";
            this.lbl_total_conta.Click += new System.EventHandler(this.Lbl_total_conta_Click);
            // 
            // Lbl_10porcento
            // 
            this.Lbl_10porcento.AutoSize = true;
            this.Lbl_10porcento.Font = new System.Drawing.Font("Arial", 12F);
            this.Lbl_10porcento.Location = new System.Drawing.Point(18, 514);
            this.Lbl_10porcento.Name = "Lbl_10porcento";
            this.Lbl_10porcento.Size = new System.Drawing.Size(48, 18);
            this.Lbl_10porcento.TabIndex = 12;
            this.Lbl_10porcento.Text = "10% :";
            // 
            // Lbl_total_conta_10porcento
            // 
            this.Lbl_total_conta_10porcento.AutoSize = true;
            this.Lbl_total_conta_10porcento.Font = new System.Drawing.Font("Arial", 12F);
            this.Lbl_total_conta_10porcento.Location = new System.Drawing.Point(18, 542);
            this.Lbl_total_conta_10porcento.Name = "Lbl_total_conta_10porcento";
            this.Lbl_total_conta_10porcento.Size = new System.Drawing.Size(146, 18);
            this.Lbl_total_conta_10porcento.TabIndex = 11;
            this.Lbl_total_conta_10porcento.Text = "Total Conta c/ 10% :";
            // 
            // Pnl_conta_detalhada
            // 
            this.Pnl_conta_detalhada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Pnl_conta_detalhada.AutoScroll = true;
            this.Pnl_conta_detalhada.Controls.Add(this.dataGridView1);
            this.Pnl_conta_detalhada.Font = new System.Drawing.Font("Arial", 8F);
            this.Pnl_conta_detalhada.Location = new System.Drawing.Point(16, 55);
            this.Pnl_conta_detalhada.Name = "Pnl_conta_detalhada";
            this.Pnl_conta_detalhada.Size = new System.Drawing.Size(458, 406);
            this.Pnl_conta_detalhada.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dt_produto,
            this.dt_qtd,
            this.dt_valor,
            this.dt_total,
            this.dt_excluir_item});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Lbl_conta_detalhe
            // 
            this.Lbl_conta_detalhe.Font = new System.Drawing.Font("Arial", 12F);
            this.Lbl_conta_detalhe.Location = new System.Drawing.Point(13, 28);
            this.Lbl_conta_detalhe.Name = "Lbl_conta_detalhe";
            this.Lbl_conta_detalhe.Size = new System.Drawing.Size(151, 23);
            this.Lbl_conta_detalhe.TabIndex = 0;
            this.Lbl_conta_detalhe.Text = "Conta Detalhada:";
            // 
            // Pnl_center
            // 
            this.Pnl_center.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_center.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_center.Controls.Add(this.Lbl_nomeGarcom);
            this.Pnl_center.Controls.Add(this.Lbl_mesaNumero);
            this.Pnl_center.Controls.Add(this.Btn_inclui_produto);
            this.Pnl_center.Controls.Add(this.Lbl_nomeCLiente);
            this.Pnl_center.Controls.Add(this.Lbl_horaDeInicio);
            this.Pnl_center.Location = new System.Drawing.Point(307, 14);
            this.Pnl_center.Name = "Pnl_center";
            this.Pnl_center.Size = new System.Drawing.Size(334, 575);
            this.Pnl_center.TabIndex = 9;
            // 
            // Lbl_nomeGarcom
            // 
            this.Lbl_nomeGarcom.AutoSize = true;
            this.Lbl_nomeGarcom.Font = new System.Drawing.Font("Arial", 12F);
            this.Lbl_nomeGarcom.Location = new System.Drawing.Point(26, 254);
            this.Lbl_nomeGarcom.Name = "Lbl_nomeGarcom";
            this.Lbl_nomeGarcom.Size = new System.Drawing.Size(114, 18);
            this.Lbl_nomeGarcom.TabIndex = 11;
            this.Lbl_nomeGarcom.Text = "Nome Garçom:";
            // 
            // Btn_inclui_produto
            // 
            this.Btn_inclui_produto.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Btn_inclui_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_inclui_produto.Enabled = false;
            this.Btn_inclui_produto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_inclui_produto.Font = new System.Drawing.Font("Arial", 12F);
            this.Btn_inclui_produto.Location = new System.Drawing.Point(29, 500);
            this.Btn_inclui_produto.Name = "Btn_inclui_produto";
            this.Btn_inclui_produto.Size = new System.Drawing.Size(180, 46);
            this.Btn_inclui_produto.TabIndex = 8;
            this.Btn_inclui_produto.Text = "Incluir Produto";
            this.Btn_inclui_produto.UseVisualStyleBackColor = false;
            this.Btn_inclui_produto.Click += new System.EventHandler(this.Btn_inclui_produto_Click);
            // 
            // Pnl_east
            // 
            this.Pnl_east.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Pnl_east.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_east.Controls.Add(this.Btn_finaliza_mesa);
            this.Pnl_east.Controls.Add(this.Btn_inicia_mesa);
            this.Pnl_east.Controls.Add(this.Txt_garcom);
            this.Pnl_east.Controls.Add(this.Lbl_nome_cliente);
            this.Pnl_east.Controls.Add(this.Lbl_garcom);
            this.Pnl_east.Controls.Add(this.Txt_nome_cliente);
            this.Pnl_east.Location = new System.Drawing.Point(14, 14);
            this.Pnl_east.Name = "Pnl_east";
            this.Pnl_east.Size = new System.Drawing.Size(287, 575);
            this.Pnl_east.TabIndex = 8;
            // 
            // Btn_finaliza_mesa
            // 
            this.Btn_finaliza_mesa.BackColor = System.Drawing.Color.Salmon;
            this.Btn_finaliza_mesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_finaliza_mesa.Enabled = false;
            this.Btn_finaliza_mesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_finaliza_mesa.Font = new System.Drawing.Font("Arial", 12F);
            this.Btn_finaliza_mesa.Location = new System.Drawing.Point(19, 500);
            this.Btn_finaliza_mesa.Name = "Btn_finaliza_mesa";
            this.Btn_finaliza_mesa.Size = new System.Drawing.Size(125, 46);
            this.Btn_finaliza_mesa.TabIndex = 8;
            this.Btn_finaliza_mesa.Text = "Finalizar Mesa";
            this.Btn_finaliza_mesa.UseVisualStyleBackColor = false;
            this.Btn_finaliza_mesa.Click += new System.EventHandler(this.Btn_finaliza_mesa_Click);
            // 
            // Btn_inicia_mesa
            // 
            this.Btn_inicia_mesa.BackColor = System.Drawing.Color.GreenYellow;
            this.Btn_inicia_mesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_inicia_mesa.Enabled = false;
            this.Btn_inicia_mesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_inicia_mesa.Font = new System.Drawing.Font("Arial", 12F);
            this.Btn_inicia_mesa.Location = new System.Drawing.Point(19, 28);
            this.Btn_inicia_mesa.Name = "Btn_inicia_mesa";
            this.Btn_inicia_mesa.Size = new System.Drawing.Size(125, 46);
            this.Btn_inicia_mesa.TabIndex = 3;
            this.Btn_inicia_mesa.Text = "Iniciar Mesa";
            this.Btn_inicia_mesa.UseVisualStyleBackColor = false;
            this.Btn_inicia_mesa.Click += new System.EventHandler(this.Btn_inicia_mesa_Click);
            // 
            // Txt_garcom
            // 
            this.Txt_garcom.Font = new System.Drawing.Font("Arial", 12F);
            this.Txt_garcom.Location = new System.Drawing.Point(19, 254);
            this.Txt_garcom.Name = "Txt_garcom";
            this.Txt_garcom.Size = new System.Drawing.Size(252, 26);
            this.Txt_garcom.TabIndex = 7;
            this.Txt_garcom.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Lbl_nome_cliente
            // 
            this.Lbl_nome_cliente.AutoSize = true;
            this.Lbl_nome_cliente.Font = new System.Drawing.Font("Arial", 12F);
            this.Lbl_nome_cliente.Location = new System.Drawing.Point(16, 158);
            this.Lbl_nome_cliente.Name = "Lbl_nome_cliente";
            this.Lbl_nome_cliente.Size = new System.Drawing.Size(107, 18);
            this.Lbl_nome_cliente.TabIndex = 4;
            this.Lbl_nome_cliente.Text = "Nome Cliente:";
            this.Lbl_nome_cliente.Click += new System.EventHandler(this.Lbl_nome_cliente_Click);
            // 
            // Lbl_garcom
            // 
            this.Lbl_garcom.AutoSize = true;
            this.Lbl_garcom.Font = new System.Drawing.Font("Arial", 12F);
            this.Lbl_garcom.Location = new System.Drawing.Point(16, 233);
            this.Lbl_garcom.Name = "Lbl_garcom";
            this.Lbl_garcom.Size = new System.Drawing.Size(68, 18);
            this.Lbl_garcom.TabIndex = 6;
            this.Lbl_garcom.Text = "Garçom:";
            this.Lbl_garcom.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Txt_nome_cliente
            // 
            this.Txt_nome_cliente.Font = new System.Drawing.Font("Arial", 12F);
            this.Txt_nome_cliente.Location = new System.Drawing.Point(19, 179);
            this.Txt_nome_cliente.Name = "Txt_nome_cliente";
            this.Txt_nome_cliente.Size = new System.Drawing.Size(252, 26);
            this.Txt_nome_cliente.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dt_produto
            // 
            this.dt_produto.HeaderText = "Produto";
            this.dt_produto.Name = "dt_produto";
            this.dt_produto.Width = 150;
            // 
            // dt_qtd
            // 
            this.dt_qtd.HeaderText = "Qtd";
            this.dt_qtd.Name = "dt_qtd";
            this.dt_qtd.Width = 50;
            // 
            // dt_valor
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dt_valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.dt_valor.HeaderText = "Valor";
            this.dt_valor.Name = "dt_valor";
            this.dt_valor.Width = 75;
            // 
            // dt_total
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dt_total.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_total.HeaderText = "Total";
            this.dt_total.Name = "dt_total";
            this.dt_total.Width = 75;
            // 
            // dt_excluir_item
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dt_excluir_item.DefaultCellStyle = dataGridViewCellStyle3;
            this.dt_excluir_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dt_excluir_item.HeaderText = "Excluir";
            this.dt_excluir_item.Name = "dt_excluir_item";
            this.dt_excluir_item.Text = "X";
            this.dt_excluir_item.UseColumnTextForButtonValue = true;
            this.dt_excluir_item.Width = 50;
            // 
            // Frm_MesaInformacaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1160, 628);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_MesaInformacaoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Mesa";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_MesaInformacaoView_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Pnl_conta_detalhada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Pnl_center.ResumeLayout(false);
            this.Pnl_center.PerformLayout();
            this.Pnl_east.ResumeLayout(false);
            this.Pnl_east.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_mesaNumero;
        private System.Windows.Forms.Label Lbl_nomeCLiente;
        private System.Windows.Forms.Label Lbl_horaDeInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_nome_cliente;
        private System.Windows.Forms.Button Btn_inicia_mesa;
        private System.Windows.Forms.Label Lbl_garcom;
        private System.Windows.Forms.TextBox Txt_nome_cliente;
        private System.Windows.Forms.TextBox Txt_garcom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Pnl_center;
        private System.Windows.Forms.Panel Pnl_east;
        private System.Windows.Forms.Button Btn_inclui_produto;
        private System.Windows.Forms.Label Lbl_total_conta_10porcento;
        private System.Windows.Forms.Button Btn_finaliza_mesa;
        private System.Windows.Forms.Panel Pnl_conta_detalhada;
        private System.Windows.Forms.Label Lbl_conta_detalhe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_total_conta;
        private System.Windows.Forms.Label Lbl_10porcento;
        private System.Windows.Forms.Label Lbl_nomeGarcom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_valor_conta;
        private System.Windows.Forms.Label lbl_total_com_10porcento;
        private System.Windows.Forms.Label lbl_valor_10porcento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_total;
        private System.Windows.Forms.DataGridViewButtonColumn dt_excluir_item;
    }
}