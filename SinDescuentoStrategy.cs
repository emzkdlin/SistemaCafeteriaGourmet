using SistemaCafeteriaGourmet.Interfaz;

namespace SistemaCafeteriaGourmet.Logica
{
    public class SinDescuentoStrategy : IEstrategiaDescuento
    {
        public string Nombre => "Sin descuento";
        public double Porcentaje => 0;

        public double CalcularDescuento(double subtotal)
        {
            return 0;
        }
    }
}
