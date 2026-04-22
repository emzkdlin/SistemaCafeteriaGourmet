namespace SistemaCafeteriaGourmet.Interfaz
{
    public interface IEstrategiaDescuento
    {
        string Nombre { get; }
        double Porcentaje { get; }
        double CalcularDescuento(double subtotal);
    }
}
