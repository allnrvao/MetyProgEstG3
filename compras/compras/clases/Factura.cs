using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//usar programacion multihibridos

namespace compras.clases
{
    internal class Factura
    {
        public string producto {  get; set; } //el public es un modificador que se puede acceder desde cualquier elemento
        public double precio { get; set; } // get obtiene el valor, set asigna el valor
        public int cantidad { get; set; }

        public double CalcularMonto()
        {
            return this.precio * this.cantidad;
        }
        public Factura() { }//contructor: es algo que habilita crear nuevos objetos
    }
}
