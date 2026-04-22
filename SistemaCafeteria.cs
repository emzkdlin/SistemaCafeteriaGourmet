using SistemaCafeteriaGourmet.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SistemaCafeteriaGourmet.Logica
{
    public class SistemaCafeteria
    {
        private static SistemaCafeteria? instancia;

        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Producto> Productos { get; set; } = new List<Producto>();
        [JsonIgnore]
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public SistemaCafeteria()
        {
      
        }

        public static SistemaCafeteria ObtenerInstancia
        {
            get
            {
                if (instancia == null)
                {
                    //Si no existe una instancia, se crea una nueva. 
                    instancia = new SistemaCafeteria();
                }
                //Si ya existe una instancia, se devuelve la instancia existente.
                return instancia;
            }
        }

        public static void SetInstancia(SistemaCafeteria sistema)
        {
            //Permite establecer una nueva instancia del sistema de cafetería, reemplazando la instancia actual.
            instancia = sistema;
        }

        public double CalcularVentasHoy()
        {
            return Pedidos
                .Where(p => p.Fecha.Date == DateTime.Today)
                .Sum(p => p.CalcularTotal());
        }

        public int CantidadPedidosHoy()
        {
            return Pedidos.Count(p => p.Fecha.Date == DateTime.Today);
        }
        public double PromedioVentasHoy()
        {
            var pedidosHoy = Pedidos
                .Where(p => p.Fecha.Date == DateTime.Today);

            if (!pedidosHoy.Any()) return 0;

            return pedidosHoy.Average(p => p.CalcularTotal());
        }

    }
    
}
