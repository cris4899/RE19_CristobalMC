using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE19V2_CristobalMC
{
    public static class Controlador
    {
        public static void MostrarListado(Vehiculo[] listaCoches)
        {
            Interfaz.MostrarListaCoches(listaCoches);
        }

        internal static void MostrarVehiculo(Vehiculo[] listaCoches)
        {
            // RECURSOS
            int seleccion = 0;

            // 1.- Mostrar Lista Vehículos

            // 2.- Seleccionar Vehículo

            // 3.- Validar Selección

            // 4.- Mostrar Retroalimentación

            // 5.- Mostrar los datos del Vehículo
            Interfaz.MostrarDatosCoche(listaCoches[seleccion]);
            
        }
    }
}
