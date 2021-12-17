using System;
using System.IO;
using System.Collections.Generic;

namespace TrabajoFinal
{
    class Program
    {

        static void Main(string[] args)
        {
            Archivo personas = new Archivo("personas.txt");
            Archivo vacunas = new Archivo("vacunas.txt");
            Archivo vacunaciones = new Archivo("vacunaciones.txt");


            string titulo = "Bienvenido al Centro de Vacunacion";
            string[] array = new string[4];
            array[0] = "Registrar Persona";
            array[1] = "Registrar Vacuna";
            array[2] = "Registrar Vacunacion";
            array[3] = "listar personas";

            MenuGral principal = new MenuGral(titulo, array);

            int seleccion = 0;
            while (seleccion > -1)
            {
                seleccion = principal.Mostrar();

                if (seleccion == 0)
                {
                    Console.Clear();


                    Ingresar_Datos datos_personales = new Ingresar_Datos();
                    Persona persona = datos_personales.SolicitarDatosPersonales();

                    personas.escribirarchivo(persona);
                }

                if (seleccion == 1)
                {
                    Console.Clear();

                    Ingresar_Datos datos_vacuna = new Ingresar_Datos();
                    Vacuna vacuna = datos_vacuna.SolicitarDatosVacuna();
                    vacunas.escribirarchivo(vacuna);
                }

                if (seleccion == 2)
                {
                    Console.Clear();

                    Ingresar_Datos datos_vacunacion = new Ingresar_Datos();
                    Vacunacion vacunacion = datos_vacunacion.SolicitarDatosVacunacion();
                    vacunaciones.escribirarchivo(vacunacion);
                }

                if (seleccion == 3)
                {

                    personas.Deserealizar();
                    Console.ReadLine();




                }
            }




        }
    }
}
