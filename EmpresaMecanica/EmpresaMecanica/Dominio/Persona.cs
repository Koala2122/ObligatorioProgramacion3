using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMecanica.Dominio
{
    class Persona
    {
        public int _cedula;
        public string _nombre;
        public string _telefono;

        //Metodos de la clase

        public int Cedula {
            get {
                return _cedula;
            }

            set
            {

                _cedula = value;

            }

        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set {

                _nombre = value;

            }


        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {

                _telefono = value;

            }


        }

        public override string ToString()
        {
            return this.Cedula + " " + this.Nombre + " " + this.Telefono;
        }

        public Persona(int pCedula, string pNombre, string pTelefono) {

            this.Cedula = pCedula;
            this.Nombre = pNombre;
            this.Telefono = pTelefono;



        }








    }
}
