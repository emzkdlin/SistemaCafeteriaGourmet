using SistemaCafeteriaGourmet.Interfaz;

namespace SistemaCafeteriaGourmet.Logica
{
    public class DescuentoClienteFrecuenteStrategy : IEstrategiaDescuento
    {
        public string Nombre => "Cliente frecuente (10%)";
        public double Porcentaje => 10;

        public double CalcularDescuento(double subtotal)
        {
            return subtotal * 0.10;
        }
    }
}
