using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using SistemaCafeteriaGourmet.Interfaz;
using SistemaCafeteriaGourmet.Logica;

namespace SistemaCafeteriaGourmet.Entidades
{
    public class Pedido
    {
        [JsonIgnore]
        public string Numero { get; set; }

        [JsonIgnore]
        public DateTime Fecha { get; set; }

        [JsonIgnore]
        public Cliente? Cliente { get; set; }

        [JsonIgnore]
        public List<DetallePedido> ListaDetalles { get; set; } = new List<DetallePedido>();

        [JsonIgnore]
        public IEstrategiaDescuento EstrategiaDescuento { get; set; }

       
        public Pedido(Cliente cliente)
        {
            Numero = string.Empty;
            Cliente = cliente;
            EstrategiaDescuento = new SinDescuentoStrategy();
        }

        public void AgregarProducto(Producto producto, int cantidad)
        {
            DetallePedido detalle = new DetallePedido(producto, cantidad);
            ListaDetalles.Add(detalle);
        }

        public void AsignarDescuento(IEstrategiaDescuento estrategiaDescuento)
        {
            //evitar null
            EstrategiaDescuento = estrategiaDescuento ?? new SinDescuentoStrategy();
        }

        public double CalcularSubtotal()
        {
            double total = 0;

            foreach (var detalle in ListaDetalles)
            {
                total += detalle.CalcularSubtotal();
            }

            return total;
        }

        public double CalcularDescuento()
        {
            return (EstrategiaDescuento ?? new SinDescuentoStrategy()).CalcularDescuento(CalcularSubtotal());
        }
        public double CalcularTotal()
        {
            return CalcularSubtotal() - CalcularDescuento();
        }
    }
}
