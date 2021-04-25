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

        //public GrupoMesa()
        //{
        //    listaDeMesa = new List<Mesa>();
        //}


        public Mesa buscaMesa(int indice)
        {
            return listaDeMesa[indice];
        }

        public void adicionaMesaNaLista(Mesa mesa)
        {
            listaDeMesa.Add(mesa);
        }

        

    }
}
