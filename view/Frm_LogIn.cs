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

namespace view
{
    public partial class Frm_LogIn : Form
    {
       
        public Frm_LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
          
        }

       

        private void lbl_enviar_Click(object sender, EventArgs e)
        {
            string username = Txt_usuario.Text;
            string senha = Txt_senha.Text;

            Usuario usuario = new Usuario(username, senha);

            ControllerUser controllerUser = new ControllerUser();

            controllerUser.VerificaUsuario(usuario);

            if (controllerUser.VerificaUsuario(usuario))
            {
                Console.WriteLine("usuario autenticado");

                this.iniciaHomePage();

                //this.Hide();


                //frm_homePage.ShowDialog();
            }
            else
            {
              
                Console.WriteLine("usuario recusado");
            }
        }

       
        private void iniciaHomePage()
        {
            this.Hide();
            Frm_HomePage frm_homePage = new Frm_HomePage();
            frm_homePage.ShowDialog();
            Application.Exit();

        }
       



        private void Txt_usuario_MouseHover(object sender, EventArgs e)
        {
            if (Txt_usuario.Text == "Username")
            {
                Txt_usuario.Text = "";
            }
        }

       

        private void Txt_usuario_Leave(object sender, EventArgs e)
        {
            if (Txt_usuario.Text == "")
            {
                Txt_usuario.Text = "Username";
            }
        }

        private void Txt_senha_MouseClick(object sender, MouseEventArgs e)
        {
            if (Txt_senha.Text == "Senha")
            {
                Txt_senha.Text = "";
            }
        }

        private void Txt_senha_Leave(object sender, EventArgs e)
        {
            if (Txt_senha.Text == "")
            {
                Txt_senha.Text = "Senha";
            }
        }
    }
}
