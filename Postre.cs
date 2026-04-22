using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SistemaCafeteriaGourmet.Entidades
{
    public class Postre : Producto
    {
        
        public bool TieneAzucar { get; set; }
       
        public Postre() { }
       
        public Postre(int codigo, string nombre, double precio, bool tieneAzucar)
            : base(codigo, nombre, precio)
        {
            TieneAzucar = tieneAzucar;
        }
       
        public override double CalcularPrecio()
        {
            return Precio;
        } 
    }
}
