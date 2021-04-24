using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Garcom
    {
        private string id_garcom;
        private string nome;

        public Garcom(string id_garcom, string nome)
        {
            this.Id_garcom = id_garcom;
            this.Nome = nome;
        }

        public string Id_garcom { get => id_garcom; set => id_garcom = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
