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
    public partial class Frm_garcomExclui : Form
    {
        public Frm_garcomExclui()
        {
            InitializeComponent();
        }

        private void Frm_garcomExclui_Load(object sender, EventArgs e)
        {

        }
        private void Lbl_Nome_Click(object sender, EventArgs e)
        {

        }

    

        private void Txt_produto_nome_TextChanged(object sender, EventArgs e)
        {

        }




      
        private void btn_excluirGarcom_Click_1(object sender, EventArgs e)
        {
            string cpfGarcom = txt_cpf_exclusao.Text;
            
            GarcomController garcomController = new GarcomController();

            Garcom garcom = new Garcom(cpfGarcom,"");

            garcomController.deletaGarcom(garcom.Cpf_garcom);

            this.Close();
        }

        private void txt_cpf_exclusao_Leave(object sender, EventArgs e)
        {
            string cpfGarcom = txt_cpf_exclusao.Text;

            GarcomController garcomController = new GarcomController();

            Garcom garcom = new Garcom(cpfGarcom, "");

            garcom = garcomController.consultaGarcom(cpfGarcom);

            lbl_nome_garcom_info.Text = garcom.Nome;
            lbl_cpf_do_garcom_info.Text = garcom.Cpf_garcom;

        }

        private void lbl_nome_garcom_info_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cpf_do_garcom_info_Click(object sender, EventArgs e)
        {

        }

       
    }
}
