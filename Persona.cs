using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    class Persona
    {
        //private int idpersona;
        private string nombre;
        private string apellido;
        private string tiponumdoc;
        private int numdoc;
        private string nacionalidad;
        private DateTime fechanacimiento;
        private string telefonopersonal;
        private string telefonoemergencia;
        private string email;
        private string ciudad;
        private string provincia;
        private string codigopostal;
        private string calle;
        private int callenumero;

        public Persona(string _nombre, string _apellido) {
            this.nombre = _nombre;
            this.apellido = _apellido;
        }
        public Persona(string _nombre, string _apellido, string _tiponumdoc, int _numdoc, string _nacionalidad, DateTime _fechanacimiento, string _telefonopersonal, string _telefonoemergencia, string _email, string _ciudad, string _provincia, string _codigopostal, string _calle, int _callenumero)
        {
            //this.idpersona = _idpersona;
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.tiponumdoc = _tiponumdoc;
            this.numdoc = _numdoc;
            this.nacionalidad = _nacionalidad;
            this.fechanacimiento = _fechanacimiento;
            this.telefonopersonal = _telefonopersonal;
            this.telefonoemergencia = _telefonoemergencia;
            this.email = _email;
            this.ciudad = _ciudad;
            this.provincia = _provincia;
            this.codigopostal = _codigopostal;
            this.calle = _calle;
            this.callenumero = _callenumero;
        }

        public Persona(){}

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string TipoNumDoc { get => tiponumdoc; set => tiponumdoc = value; }
        public int NumDoc { get => numdoc; set => numdoc = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public DateTime FechaNacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public string TelefonoPersonal { get => telefonopersonal; set => telefonopersonal = value; }
        public string TelefonoEmergencia { get => telefonoemergencia; set => telefonoemergencia = value; }
        public string Email { get => email; set => email = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Codigopostal { get => codigopostal; set => codigopostal = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Callenumero { get => callenumero; set => callenumero = value; }

        
    }

    
}
