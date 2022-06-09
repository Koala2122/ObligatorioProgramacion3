using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMecanica.Dominio
{
    class Administrado : Persona
    {
        private int _idAdmin;
        private string _tipoAdmin;
        private Persona _nombre;
        private Persona _ci;
        private Persona _TelefonoADM;




        public int idAdmin
        {



            get
            {
                return _idAdmin
                    ;

            }

            set
            {

                _idAdmin = value;


            }



        }


        public string tipoAdmin {

            get { 
            
                return _tipoAdmin; 
            }

            set
            {
                _tipoAdmin = value; 

            }
        
        }

        public Persona nombre
        {
            get
            {
                return _nombre;
            }


            set { 
            _nombre = value;
    
            }
        
        
        
        }

        public Persona ci {

            get { return _ci;}

            set { _ci=value; }
        }


        public Persona TelefonoADM
        {

            get { return _TelefonoADM; }

            set { _TelefonoADM = value; }

        }
    }


}


