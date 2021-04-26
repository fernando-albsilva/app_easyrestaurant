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
    public partial class Frm_PopUpSair : Form
    {
        public Frm_PopUpSair()
        {
            InitializeComponent();
        }


        private void Btn_sair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

     

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Console.WriteLine("cancelou");
        }
    }
}
