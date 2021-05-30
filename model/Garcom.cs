
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Garcom
    {
        private string cpf;
        private string nome;

        public Garcom(string id_garcom, string nome)
        {
            this.cpf = id_garcom;
            this.Nome = nome;
        }

        public string Cpf_garcom { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}