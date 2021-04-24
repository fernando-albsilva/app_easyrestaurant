using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace DAO
{
    public class DAOUser
    {

        public bool VerificaUsuarioNoBanco(Usuario usuario)
        {
            if(usuario.Nome == "fernando" && usuario.Senha == "200790")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
