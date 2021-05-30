using model;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control
{
    public class GarcomController
    {
        public void insereGarcom(Garcom garcom)
        {
            DAOGarcom garcomDAO = new DAOGarcom();
            garcomDAO.insereGarcom(garcom);

        }

        public Garcom consultaGarcom(string cpfPK)
        {
            Garcom garcom = new Garcom(cpfPK, "");
            DAOGarcom garcomDAO = new DAOGarcom();
            garcom=garcomDAO.consultaGarcom(garcom);


            return garcom;
        }

        public void deletaGarcom(string cpfPK)
        {
            Garcom garcom = new Garcom(cpfPK, "");
            DAOGarcom garcomDAO = new DAOGarcom();
            garcomDAO.deletaGarcom(garcom.Cpf_garcom);

        }

        public void alteraGarcom(Garcom garcom, string cpfPK)
        {
            
            DAOGarcom garcomDAO = new DAOGarcom();
            garcomDAO.alteraGarcom(garcom,cpfPK);

        }
    }
}
