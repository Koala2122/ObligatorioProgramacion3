using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMecanica.Dominio
{
    public class Mecanico: Persona
    {
        private int _idMecanico;
        private Persona _nombre;
        private Persona _cedula;
        private Persona _telefono;
        private int _precioXHoraT;
        private string _mecActivo;


        public int IdMecanico
        {

            get
            {
                return _idMecanico;
            }

            set
            {

                _idMecanico = value;

            }

        }


        public Persona NombreMec
        {

            get
            {
                return _nombre;
            }

            set
            {

                _nombre = value;

            }

        }

        public Persona CedulaMec
        {

            get
            {
                return _cedula;
            }

            set
            {

                _cedula = value;

            }

        }


        public Persona TelefonoMec
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



        public int PreciodeHoraTrabajada
        {

            get
            {
                return _precioXHoraT;
            }

            set
            {

                _precioXHoraT = value;

            }

        }

        public string MecanicoActivo {

            get
            {
                return _mecActivo;

                    
            }
            
            
            set {

                _mecActivo = value;
            
            }
        
        }

        public override string ToString()
        {
            return this.IdMecanico + " " + this.NombreMec + " " + this.CedulaMec + " " + this.TelefonoMec + " " + this.PreciodeHoraTrabajada + " " + this.MecanicoActivo;
        }

        public Mecanico(int idMecanico, Persona nombre, Persona cedula, Persona telefono, int precioXHoraT, string mecActivo, int idMecanico, Persona nombreMec, Persona cedulaMec, Persona telefonoMec, int preciodeHoraTrabajada, string mecanicoActivo)
        {
            IdMecanico = idMecanico;
            _nombre = nombre;
            _cedula = cedula;
            _telefono = telefono;
            _precioXHoraT = precioXHoraT;
            _mecActivo = mecActivo;
            IdMecanico = idMecanico;
            NombreMec = nombreMec;
            CedulaMec = cedulaMec;
            TelefonoMec = telefonoMec;
            PreciodeHoraTrabajada = preciodeHoraTrabajada;
            MecanicoActivo = mecanicoActivo;
        }



        
    }
}
