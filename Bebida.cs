using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SistemaCafeteriaGourmet.Entidades
{
    public class Bebida : Producto
    {
       
        public Bebida() { }

        public TamanhoBebida Tamanho { get; set; }
    
        public Bebida(int codigo, string nombre, double precio, TamanhoBebida tamanho)
             : base(codigo, nombre, precio)
        {
            Tamanho = tamanho;
        }



        public override double CalcularPrecio()
        {
            return Precio /*+ (int)Tamanho*/;
        }
    }
}
