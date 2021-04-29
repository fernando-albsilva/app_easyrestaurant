﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;
using view.viewMesaInformacao;
using view.viewPopUp;

namespace view
{
    public partial class Frm_HomePage : Form
    {
        GrupoMesa grupoMesa = new GrupoMesa();
        public Frm_HomePage()
        {

            // testa se as 15 mesas foram inicializadas na lista na main

            //GrupoMesa grupoMesa = new GrupoMesa();

            //Mesa mesa;

            //for(int i=0; i<15;i++)
            //{
            //    mesa = (grupoMesa.buscaMesa(i));
            //    Console.WriteLine("numero da mesa : " + mesa.Numero);
            //    Console.WriteLine("Nome Cliente : " + mesa.NomeCliente);
            //    Console.WriteLine("numero da mesa : " + mesa.HoraInicio);
            //}
     
            //

            
            InitializeComponent();
          
        }

        private void Frm_HomePage_Load(object sender, EventArgs e)
        {

        }

       

        private void Pnl_south_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Mnu_east_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Btn_mesa1_Click(object sender, EventArgs e)
        {
            
            grupoMesa.AdicionaNumeroDaMesaParaConsulta(Btn_mesa_1.Name);
            Frm_MesaInformacaoView frm_mesaInformacaoView = new Frm_MesaInformacaoView();
            frm_mesaInformacaoView.ShowDialog();
            if (!this.VerificaDisponibilidadeMesa())
            {
                this.Btn_mesa_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(132)))), ((int)(((byte)(5)))));
            }
            else
            {
                this.Btn_mesa_1.BackColor = System.Drawing.Color.Gainsboro;
            }
           
            
        }
        private void Btn_mesa2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            
            Frm_PopUpSair popUpSair = new Frm_PopUpSair();
            

            if (popUpSair.ShowDialog(this) == DialogResult.OK)
            {
                Application.Exit();
            }
           

        }

        private bool VerificaDisponibilidadeMesa()
        {
            Mesa mesa = grupoMesa.BuscaMesa();
            return mesa.Disponibilidade;
        }

        private void Pnl_north_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
