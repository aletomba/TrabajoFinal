using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    class Vacuna
    {
        //private int idvacuna;
        private string nombre;
        private int dosis;
        private string procedencia;

        public Vacuna (string _nombre, int _dosis, string _procedencia)
        {
            //this.IDvacuna = _idvacuna;
            this.nombre = _nombre;
            this.dosis = _dosis;
            this.procedencia = _procedencia;
        }

        public Vacuna() { }
        //public int IDvacuna { get => idvacuna; set => idvacuna = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Dosis { get => dosis; set => dosis = value; }
        public string Procedencia { get => procedencia; set => procedencia = value; }

        
    }
}
