using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;


namespace SistemaCafeteriaGourmet.Entidades
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(Bebida), "bebida")]
    [JsonDerivedType(typeof(Postre), "postre")]
    public abstract class Producto
    {
        public int Codigo { get; set; }
        public string? Nombre { get; set; }
        public double Precio { get; set; }

       

        public Producto() { }
        public Producto(int codigo, string nombre, double precio)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
        }
       
        public override string ToString()
        {
            return Nombre + " - ₡" + Precio;
        } 
        public abstract double CalcularPrecio();
    }
}
