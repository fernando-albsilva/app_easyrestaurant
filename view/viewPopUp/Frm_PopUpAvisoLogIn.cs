using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view.viewPopUp
{
    public partial class Frm_PopUpAvisoLogIn : Form
    {
        public Frm_PopUpAvisoLogIn()
        {
            InitializeComponent();
        }
     

      

        private void Lbl_informacaoSair_Click(object sender, EventArgs e)
        {

        }
        private void Frm_PopUpAvisoLogIn_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Console.WriteLine("cancelou");
        }
    }
}
