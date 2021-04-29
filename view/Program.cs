using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;

namespace view
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        

        [STAThread]
        static void Main()
        {
            GrupoMesa  grupoMesa = new GrupoMesa();
            for ( int i=0; i<15;i++)
            {
                Mesa mesa = new Mesa(i.ToString());
                grupoMesa.AdicionaMesaNaLista(mesa);
            }
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_LogIn());
        }
    }
}
