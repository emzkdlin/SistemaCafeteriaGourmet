using SistemaCafeteriaGourmet.Interfaz;

namespace SistemaCafeteriaGourmet.Logica
{
    public class DescuentoPromocionEspecialStrategy : IEstrategiaDescuento
    {
        public string Nombre => "Promoción especial (20%)";
        public double Porcentaje => 20;

        public double CalcularDescuento(double subtotal)
        {
            return subtotal * 0.20;
        }
    }
}
