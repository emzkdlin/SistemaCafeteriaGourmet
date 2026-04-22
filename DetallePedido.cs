using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SistemaCafeteriaGourmet.Entidades
{
    public class DetallePedido
    {

        [JsonIgnore]
        public Producto Producto { get; set; }

        [JsonIgnore]
        public int Cantidad { get; set; }

    
        public DetallePedido(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public double CalcularSubtotal()
        {
            return Producto.CalcularPrecio() * Cantidad;
        }
    }
}
