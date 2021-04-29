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
using view.viewProduto;

namespace view.viewMesaInformacao
{
    public partial class Frm_MesaInformacaoView : Form
    {
        GrupoMesa grupoMesa = new GrupoMesa();
        public Frm_MesaInformacaoView()
        {
            InitializeComponent();
           
          
        }

        private void Frm_MesaInformacaoView_Load(object sender, EventArgs e)
        {
            Mesa mesa = grupoMesa.BuscaMesa();
            if (mesa.Disponibilidade)
            {
                this.Btn_inicia_mesa.Enabled = true;
            }
            else
            {
                this.Btn_inicia_mesa.Enabled = false;
                this.Btn_finaliza_mesa.Enabled = true;
                this.Btn_inclui_produto.Enabled = true;
                this.Btn_edita_produto.Enabled = true;
                this.Btn_excluir_produto.Enabled = true;
                this.Lbl_mesaNumero.Text += " " + mesa.Numero+1;
                this.Lbl_nomeCLiente.Text += " " + mesa.NomeCliente;
                this.Lbl_horaDeInicio.Text += " " + mesa.HoraInicio;
                this.Lbl_nomeGarcom.Text += " " + mesa.IdGarcom;

               // mesa mesa = grupomesa.buscamesa();
                this.dataGridView1.Rows.Clear();
                decimal totalConta = 0;

                foreach (Produto produto in mesa.Produto)
                {
                    totalConta += (decimal)produto.Valor * (decimal)produto.Quantidade;
                    this.dataGridView1.Rows.Add(
                        new Object[]
                        {
                        produto.Nome,
                        produto.Quantidade,
                        produto.Valor,
                       ((decimal)produto.Valor*(decimal)produto.Quantidade).ToString()

                        });
                }

                this.lbl_valor_conta.Text = totalConta.ToString();
                this.lbl_valor_10porcento.Text = ((double)totalConta * 0.1).ToString();
                this.lbl_total_com_10porcento.Text = ((double)totalConta * 1.1).ToString();
            }
        }

        private void Lbl_nome_cliente_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_inicia_mesa_Click(object sender, EventArgs e)
        {
            GrupoMesa grupoMesa = new GrupoMesa();

            Mesa mesa = grupoMesa.BuscaMesa();

            mesa.NomeCliente = Txt_nome_cliente.Text;
            mesa.IdGarcom = Txt_garcom.Text;
            mesa.Disponibilidade = false;
            Console.WriteLine(mesa.Numero);
            this.Lbl_mesaNumero.Text +=" "+ mesa.Numero+1;
            this.Lbl_nomeCLiente.Text +=" "+ mesa.NomeCliente;
            this.Lbl_horaDeInicio.Text +=" "+ mesa.HoraInicio;
            this.Lbl_nomeGarcom.Text +=" "+ mesa.IdGarcom;
            this.Btn_inicia_mesa.Enabled = false;
            this.Btn_finaliza_mesa.Enabled = true;
            this.Btn_inclui_produto.Enabled = true;
            this.Btn_edita_produto.Enabled = true;
            this.Btn_excluir_produto.Enabled = true;

            grupoMesa.AdicionaMesaNaLista(mesa);

        }

        private void Btn_inclui_produto_Click(object sender, EventArgs e)
        {
            Frm_produtoCadastro frm_produtoCadastro = new Frm_produtoCadastro();
            frm_produtoCadastro.ShowDialog();
            Mesa mesa = grupoMesa.BuscaMesa();
            this.dataGridView1.Rows.Clear();
            decimal totalConta=0;

            foreach (Produto produto in mesa.Produto) {
                totalConta += (decimal)produto.Valor*(decimal)produto.Quantidade;
                this.dataGridView1.Rows.Add(
                    new Object[]
                    {
                        produto.Nome,
                        produto.Quantidade,
                        produto.Valor,
                       ((decimal)produto.Valor*(decimal)produto.Quantidade).ToString()

                    }) ;
             }
            
            this.lbl_valor_conta.Text  = totalConta.ToString();
            this.lbl_valor_10porcento.Text = ((double)totalConta*0.1).ToString();
            this.lbl_total_com_10porcento.Text = ((double)totalConta * 1.1).ToString();
            //this.dt_produto.datasource = produto.nome;
            //this.dt_qtd = produto.quantidade;
            //this.dt_valor = produto.valor;

        }

        private void Lbl_total_conta_Click(object sender, EventArgs e)
        {

        }
    }
}
