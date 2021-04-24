using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Usuario
    {
        private string nome;
        private string senha;

        public Usuario(string nome, string senha)
        {
            this.Nome = nome;
            this.Senha = senha;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
