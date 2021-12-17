using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    class Ingresar_Datos
    {
        public Ingresar_Datos() {}

        //public Vacuna SolicitarDatosVacuna() { };
        //public Vacunacion SolicitarDatosVacunatorios() { };
        public Persona SolicitarDatosPersonales ()
        {
            Console.WriteLine("Ingrese los siguientes datos de la Persona");
           
            Console.WriteLine("Nombre");
            string Nombre = Console.ReadLine();
            
            Console.WriteLine("Apellido");
            string Apellido = Console.ReadLine();

            /*Console.WriteLine("tipo de documento");
            string TipoNumDoc = Console.ReadLine();            

            Console.WriteLine("Numero de documento");
            int NumDoc = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Nacionalidad");
            string Nacionalidad = Console.ReadLine();
            
            Console.WriteLine("Fecha de Nacimiento");
            DateTime FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Telefono personal");
            string TelefonoPersonal = Console.ReadLine();

            Console.WriteLine("Telefono de emergencia");
            string TelefonoEmergencia = Console.ReadLine();

            Console.WriteLine("Email");
            string Email = Console.ReadLine();

            Console.WriteLine("Ciudad");
            string Ciudad = Console.ReadLine();

            Console.WriteLine("Provincia");
            string Provincia = Console.ReadLine();

            Console.WriteLine("Codigo Postal");
            string CodigoPostal = Console.ReadLine();

            Console.WriteLine("Calle");
            string Calle = Console.ReadLine();

            Console.WriteLine("Numero de Calle");
            int CalleNumero = int.Parse(Console.ReadLine());*/

            //Persona nuevapersona = new Persona (Nombre, Apellido, TipoNumDoc, NumDoc, Nacionalidad, FechaNacimiento, TelefonoPersonal, TelefonoEmergencia, Email, Ciudad, Provincia, CodigoPostal, Calle, CalleNumero);
            Persona nuevapersona = new Persona(Nombre, Apellido);
            return nuevapersona;

        }              

        public Vacuna SolicitarDatosVacuna () 
        {
            Console.WriteLine("Ingrese los siguientes datos de Vacuna");

            Console.WriteLine("Nombre de Vacuna");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Dosis");
            int Dosis = int.Parse(Console.ReadLine());

            Console.WriteLine("Procedencia");
            string Procedencia = Console.ReadLine();

            Vacuna nuevavacuna = new Vacuna(Nombre, Dosis, Procedencia);
            return nuevavacuna;
        }
        public Vacunacion SolicitarDatosVacunacion()            
        {
            Console.WriteLine("Ingrese los siguientes datos de Vacunacion");

            Console.WriteLine("Numero de Documento de la Persona");
            int Numdoc = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre de Vacuna");
            string Vacuna = Console.ReadLine();

            Console.WriteLine("Fecha de Vacunacion");
            DateTime Fechavacunacion = DateTime.Parse(Console.ReadLine());


            Vacunacion nuevavacunacion = new Vacunacion(Numdoc, Vacuna, Fechavacunacion);
            return nuevavacunacion;

        }
    }
}
