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

namespace view.viewMesaInformacao
{
    public partial class Frm_MesaInformacaoView : Form
    {
        GrupoMesa grupoMesa = new GrupoMesa();
        public Frm_MesaInformacaoView()
        {
            InitializeComponent();
            Mesa mesa = grupoMesa.buscaMesa();
            if(mesa.Disponibilidade)
            {

            }
            this.Lbl_mesaNumero.Text += mesa.Numero;
            this.Lbl_nomeCLiente.Text += mesa.NomeCliente;
            this.Lbl_horaDeInicio.Text += mesa.HoraInicio;
        }

        private void Frm_grupoMesaView_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_nome_cliente_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
