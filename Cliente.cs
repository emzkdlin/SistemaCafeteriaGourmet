using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCafeteriaGourmet.Entidades
{
    public class Cliente
    {
        private string? cedula;
        private string? nombre;
        private string? telefono;
        private string? correo;

        public string? Cedula { get => cedula; set => cedula = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Telefono { get => telefono; set => telefono = value; }
        public string? Correo { get => correo; set => correo = value; }


        public Cliente() { }

        public Cliente(string cedula, string nombre, string telefono, string correo)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
        }

        public override string ToString()
        {
            return $" Nombre: {nombre} - Cédula: {cedula} ";
        }
    }
}
