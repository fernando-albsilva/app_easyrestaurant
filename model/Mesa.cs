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
        private string nomeCliente;
        private string idGarcom;
        private bool disponibilidade;
        private List<Produto> listaDeProduto;
        private DateTime horaInicio;
        private DateTime horaTermino;

        public Mesa(string numero)
        {
            this.Numero = numero;
            this.listaDeProduto = new List<Produto>();
        }

        public string Numero { get => numero; set => numero = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string IdGarcom { get => idGarcom; set => idGarcom = value; }
        public bool Disponibilidade { get => disponibilidade; set => disponibilidade = value; }
        public List<Produto> Produto { get => listaDeProduto; set => listaDeProduto = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraTermino { get => horaTermino; set => horaTermino = value; }
    }
}
