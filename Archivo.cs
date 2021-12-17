using System;
using System.Text.Json;
using System.IO;


namespace TrabajoFinal
{
    class Archivo
    {
        private StreamWriter writer;

        public Archivo(string _nombrearchivo)
        {
            this.writer = new StreamWriter(_nombrearchivo);

        }

        public Archivo() { }

        public void escribirarchivo(Persona _persona)
        {
            try
            {

                File.WriteAllText("personas.json", JsonSerializer.Serialize(_persona));

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error:{ex.Message}");
            }
            finally
            {
                if (writer != null)
                {
                   
                    Console.WriteLine($"La persona se ha Registrado en el archivo");
                }
            }
        }

        public void Deserealizar()
        {
            try
            {
                

                Persona persona = JsonSerializer.Deserialize<Persona>(File.ReadAllText("personas.json"));
                Console.WriteLine(persona.Nombre);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error deserealizando {ex.Message}");
            }

        }

        public void escribirarchivo(Vacuna _vacuna)
        {
            try
            {

                writer.WriteLine(JsonSerializer.Serialize(_vacuna));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error:{ex.Message}");
            }
            finally
            {
                if (writer != null) writer.Close();
                Console.WriteLine($"La vacuna se ha Registrado en el archivo");
            }
        }

        public void escribirarchivo(Vacunacion _vacunacion)
        {
            try
            {

                writer.WriteLine(JsonSerializer.Serialize(_vacunacion));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error:{ex.Message}");
            }
            finally
            {
                if (writer != null) writer.Close();
                Console.WriteLine($"La vacunacion se ha Registrado en el archivo");
            }
        }



    }
}
