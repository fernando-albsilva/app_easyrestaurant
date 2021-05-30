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
using view.viewMesaInformacao;
using view.viewPopUp;
using view.viewProduto;
using view.viewGarcom;

namespace view
{
    public partial class Frm_HomePage : Form
    {
        GrupoMesa grupoMesa = new GrupoMesa();
        public Frm_HomePage()
        {

            // testa se as 15 mesas foram inicializadas na lista na main

            //GrupoMesa grupoMesa = new GrupoMesa();

            //Mesa mesa;

            //for(int i=0; i<15;i++)
            //{
            //    mesa = (grupoMesa.buscaMesa(i));
            //    Console.WriteLine("numero da mesa : " + mesa.Numero);
            //    Console.WriteLine("Nome Cliente : " + mesa.NomeCliente);
            //    Console.WriteLine("numero da mesa : " + mesa.HoraInicio);
            //}
     
            //

            
            InitializeComponent();
          
        }

        private void Frm_HomePage_Load(object sender, EventArgs e)
        {

        }

       

        private void Pnl_south_Paint(object sender, PaintEventArgs e)
        {

        }

     

       

        private void Mnu_east_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Btn_mesa1_Click(object sender, EventArgs e)
        {
            
            grupoMesa.AdicionaNumeroDaMesaParaConsulta(Btn_mesa_1.Name);
            Frm_MesaInformacaoView frm_mesaInformacaoView = new Frm_MesaInformacaoView();
            frm_mesaInformacaoView.ShowDialog();
            if (!this.VerificaDisponibilidadeMesa())
            {
                this.Btn_mesa_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            }
            else
            {
                this.Btn_mesa_1.BackColor = System.Drawing.Color.Gainsboro;
            }
           
            
        }


       

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            
            Frm_PopUpSair popUpSair = new Frm_PopUpSair();
            

            if (popUpSair.ShowDialog(this) == DialogResult.OK)
            {
                Application.Exit();
            }
           

        }

        private bool VerificaDisponibilidadeMesa()
        {
            Mesa mesa = grupoMesa.BuscaMesa();
            return mesa.Disponibilidade;
        }

        private void Pnl_north_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_mesa_1_MouseHover(object sender, EventArgs e)
        {
            grupoMesa.AdicionaNumeroDaMesaParaConsulta(Btn_mesa_1.Name);

            Mesa mesa = grupoMesa.BuscaMesa();
            if (!this.VerificaDisponibilidadeMesa())
            {
                this.lbl_numero_mesa.Text = "Mesa : " + (mesa.Numero+1);
                this.lbl_nome_cliente.Text = "Cliente :" + mesa.NomeCliente;
                this.lbl_nome_garcom.Text = "Garcom :" + mesa.IdGarcom;
                this.lbl_total_conta.Text = " Total Conta : R$" + mesa.TotalConta();
                this.lbl_total_conta_10porcento.Text = "Total Conta c/ 10% : R$"+ (1.1*mesa.TotalConta());
                this.Lbl_dadosMesa.Text = "Informações Mesa";
            }
           
        }

        private void Btn_mesa_1_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_numero_mesa.Text = " ";
            this.lbl_nome_cliente.Text = " ";
            this.lbl_nome_garcom.Text = " ";
            this.lbl_total_conta.Text = " ";
            this.lbl_total_conta_10porcento.Text = " ";
            this.Lbl_dadosMesa.Text = "Nenhuma Mesa selecionada.";
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_produtoCadastro frm_produtoCadastro = new Frm_produtoCadastro();
            frm_produtoCadastro.ShowDialog();
        }

        private void detalharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_produtoDetalha frm_produtoDetalha = new Frm_produtoDetalha();
            frm_produtoDetalha.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_produtoExclui frm_produtoExclui = new Frm_produtoExclui();
            frm_produtoExclui.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_produtoEdita frm_produtoEdita = new Frm_produtoEdita();
            frm_produtoEdita.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_garcomCadastra frm_garcomCadastra = new Frm_garcomCadastra();
            frm_garcomCadastra.ShowDialog();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_garcomEdita frm_garcomEdita = new Frm_garcomEdita();
            frm_garcomEdita.ShowDialog();
        }

        private void detalharToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_garcomDetalha frm_garcomDetalha = new Frm_garcomDetalha();
            frm_garcomDetalha.ShowDialog();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_garcomExclui frm_garcomExclui = new Frm_garcomExclui();
            frm_garcomExclui.ShowDialog();
        }
    }
}
