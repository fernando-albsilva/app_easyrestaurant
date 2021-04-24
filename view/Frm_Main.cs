using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            Frm_LogIn frm_LogIn = new Frm_LogIn();
            frm_LogIn.ShowDialog();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
