using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularNota.clase
{
    internal class Nota
    {
        public int calificacion1 { get; set; }
        public int calificacion2 { get; set; }
        public int calificacion3 { get; set; }
        public double CalcularPromedio()
        {
            return (this.calificacion1 + this.calificacion2 + this.calificacion3)/3;
        }
        public Nota() { }
    }
}




