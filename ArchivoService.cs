using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace SistemaCafeteriaGourmet.Logica
{
    public class ArchivoService
    {
        private static string ruta = "cafeteria.json";




        public void GuardarDatos()
        {

            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles,
                IncludeFields = true,
            };

            var json = JsonSerializer.Serialize(SistemaCafeteria.ObtenerInstancia, opciones);
            File.WriteAllText(ruta, json);

        }

        public static void CargarDatos()
        {
            try
            {
                if (!File.Exists(ruta))
                    return;

                string json = File.ReadAllText(ruta);
                SistemaCafeteria datosCargar = JsonSerializer.Deserialize<SistemaCafeteria>(json)!;//Se ocupa que el constructor sea publico

                if (datosCargar != null)  //La forma en la que se cargan los datos
                    SistemaCafeteria.SetInstancia(datosCargar);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }



}

