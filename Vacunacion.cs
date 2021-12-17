using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    class Vacunacion
    {
        //private int idvacunacion;
        private int numdoc;
        private string vacuna;
        private DateTime fechavacunacion;

        public Vacunacion(int _numdoc, string _vacuna, DateTime _fechavacunacion)
        {
            //this.idvacunacion = _idvacunacion;
            this.numdoc = _numdoc;
            this.vacuna = _vacuna;
            this.fechavacunacion = _fechavacunacion;
        }

        public Vacunacion() { }

        public int Numdoc {get => numdoc; set => numdoc = value; }
        public string Vacuna { get => vacuna; set => vacuna = value; }
        public DateTime Fechavacunacion { get => fechavacunacion; set => fechavacunacion = value; }
    }

}    

        
    

