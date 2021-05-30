using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using control;
using model;

namespace view.viewGarcom
{
    public partial class Frm_garcomCadastra : Form
    {
        public Frm_garcomCadastra()
        {
            InitializeComponent();
        }

        private void Frm_garcomCadastra_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_Nome_Click(object sender, EventArgs e)
        {

        }

     
        private void Txt_produto_nome_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void Btn_incluiGarcom_Click(object sender, EventArgs e)
        {
            string nomeGarcom  = txt_garcomNome.Text;
            string cpfGarcom = txt_garcomCpf.Text;

            Garcom garcom = new Garcom(cpfGarcom, nomeGarcom);
            GarcomController garcomController = new GarcomController();

            garcomController.insereGarcom(garcom);

            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
