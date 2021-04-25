using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class GrupoMesa

    {
        private static List<Mesa> listaDeMesa = new List<Mesa>();
        private static int indiceMesa;
        //public GrupoMesa()
        //{
        //    listaDeMesa = new List<Mesa>();
        //}


        public Mesa buscaMesa()
        {
            return listaDeMesa[indiceMesa];
        }

        public void adicionaMesaNaLista(Mesa mesa)
        {
            listaDeMesa.Add(mesa);
        }

        // Metodo retorna o numero do botao da mesa clicado
        public void adicionaNumeroDaMesaParaConsulta(string nomeBotao)
        {
            string[] novaString ;

            novaString = nomeBotao.Split('_');

            Console.WriteLine("Nome do botao : " + nomeBotao);
            //Console.WriteLine("string[0] : " + novaString[0]);
            //Console.WriteLine("string[2] : : " + novaString[1]);
            //Console.WriteLine("string[3] : : " + novaString[2]);
            indiceMesa = Int32.Parse(novaString[2]);
        }
        

    }
}
