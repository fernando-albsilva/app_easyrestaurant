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
using control;

namespace view.viewGarcom
{
    public partial class Frm_garcomDetalha : Form
    {
        public Frm_garcomDetalha()
        {
            InitializeComponent();
        }

        private void Frm_garcomDetalha_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_Nome_Click(object sender, EventArgs e)
        {

        }


        private void Txt_produto_nome_TextChanged(object sender, EventArgs e)
        {

        }


        
        private void Btn_buscaGarcom_Click(object sender, EventArgs e)
        {
            string cpfGarcom = txt_garcom_cpf.Text;

            GarcomController garcomController = new GarcomController();

            Garcom garcom = new Garcom(cpfGarcom, "");

            garcom = garcomController.consultaGarcom(cpfGarcom);

            lbl_nome_garcom_info.Text = garcom.Nome;
            lbl_cpf_do_garcom_info.Text = garcom.Cpf_garcom;

            /*this.Close();*/
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
