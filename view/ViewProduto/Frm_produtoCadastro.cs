using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;

namespace view.viewProduto
{
    public partial class Frm_produtoCadastro : Form
    {
        public Frm_produtoCadastro()
        {
            InitializeComponent();
        }

        private void Frm_produtoCadastro_Load(object sender, EventArgs e)
        {

        }



        private void Pnl_south_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Nome_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Quantidade_Click(object sender, EventArgs e)
        {

        }

        private void Txt_produto_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_inclui_produto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = txt_produto_nome.Text.ToString();
            produto.Valor = Convert.ToDecimal(txt_produto_valor.Text.ToString());
            produto.Quantidade = Convert.ToDecimal(txt_produto_quantidade.Text.ToString());

            GrupoMesa grupoMesa = new GrupoMesa();
            grupoMesa.AdicionaProdutoNaMesa(produto);

           
            this.Close();
        }
    }
}
