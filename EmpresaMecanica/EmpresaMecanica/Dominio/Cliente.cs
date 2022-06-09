using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMecanica.Dominio
{

    public class Cliente : Persona
    {

        private int _CodCli;
        private string _Email;

        public int CodCli
        {

            get
            {
                return _CodCli;
            }

            set
            {

                _CodCli = value;

            }

        }

        public string Email
        {

            get
            {
                return _Email;
            }

            set
            {

                _Email = value;

            }
        }

        public Cliente(int pCedula, string pNombre, string pTelefono, int pCodCli, string pEmail) : base(pCedula, pNombre, pTelefono)
        {

            this.CodCli = pCodCli;
            this.Email = pEmail;


        }


    }

}
