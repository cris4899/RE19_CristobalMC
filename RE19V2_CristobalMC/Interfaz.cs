using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE19V2_CristobalMC
{
    public static class Interfaz
    {
        #region MÉTODOS ENTRADA
        public static byte ObtenerOpcionMenu()
        {
            // RECURSOS

            byte seleccion = 1;

            // TODO: Implementación del Método ObtenerOpcionMenu

            // SALIDA - Método
            return seleccion;

        }

        #endregion

        #region MÉTODOS SALIDA
        internal static void MostrarListaCoches(Vehiculo[] listaCoches)
        {
            Console.Clear();

            Console.WriteLine("\t\tLista de Vehículos");
            for (int i = 0; i < listaCoches.Length; i++)
            {
                Console.WriteLine($"\t{i+1} - {listaCoches[i].Marca} {listaCoches[i].Modelo}");
            }
            Console.ReadLine();
        }
        #endregion
    }
}
