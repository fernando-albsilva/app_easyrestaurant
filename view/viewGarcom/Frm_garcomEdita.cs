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
    public partial class Frm_garcomEdita : Form
    {
        public Frm_garcomEdita()
        {
            InitializeComponent();
        }

        private void Frm_garcomEdita_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_Nome_Click(object sender, EventArgs e)
        {

        }

       
        private void Txt_produto_nome_TextChanged(object sender, EventArgs e)
        {

        }


      
        private void Btn_editarGarcom_Click(object sender, EventArgs e)
        {
            string cpfGarcom = txt_garcom_cpf.Text;
            string nomeGarcomNovo = txt_garcom_novo_nome.Text;

            GarcomController garcomController = new GarcomController();

            Garcom garcomNovo = new Garcom(cpfGarcom, nomeGarcomNovo);

            garcomController.alteraGarcom(garcomNovo,garcomNovo.Cpf_garcom);

            

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string cpfGarcom = txt_garcom_cpf.Text;

            GarcomController garcomController = new GarcomController();

            Garcom garcom = new Garcom(cpfGarcom, "");

            garcom = garcomController.consultaGarcom(cpfGarcom);

            lbl_nome_garcom_info.Text = garcom.Nome;

        }
    }
}
