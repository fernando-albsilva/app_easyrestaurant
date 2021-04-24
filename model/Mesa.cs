using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Mesa
    {
        private string numero;
        private int disponibilidade;

        public Mesa(string numero, int disponibilidade)
        {

            this.Numero = numero;
            this.Disponibilidade = disponibilidade;

        }

        public string Numero { get => numero; set => numero = value; }
        public int Disponibilidade { get => disponibilidade; set => disponibilidade = value; }

        public int verifica_disponibilidade()
        {
            return this.disponibilidade;
        }
    }
}
