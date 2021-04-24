using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using DAO;

namespace control
{

    public class ControllerUser
    {
       

        public bool VerificaUsuario(Usuario usuario)
        {
            //AQUI VAI ENTRAR O METODO QUE VAI BUSCAR O USUARIO DO BANCO DE DADOS 
            //USANDO A CLASSE DAO

            DAOUser daoUser = new DAOUser();

            return daoUser.VerificaUsuarioNoBanco(usuario);

            //if(usuario.nome == "fernando" && usuario.senha == "200790")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

        }
    }
}
