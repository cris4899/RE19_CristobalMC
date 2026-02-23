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
            // CONSTANTES
            const byte NUM_OPCIONES = 3;
            // RECURSOS
            byte seleccion = 0;
            bool esValido;
            string mensajeError = "";
            do
            {
                esValido = true;
                // 1.- Mostrar el Menú
                Console.Clear();
                Console.WriteLine("\t\t MENÚ DE ACCIONES - CONCESIONARIO");
                Console.WriteLine("");
                Console.WriteLine("\t 0 - Salir");
                Console.WriteLine("\t 1 - Mostrar lista de Vehículos");
                Console.WriteLine("\t 2 - Mostrar Vehículo");
                Console.WriteLine("");
                Console.Write("Opción: ");
                try
                {


                    // 2.- Obtener la Opción
                    seleccion = Convert.ToByte(Console.ReadLine());
                    // 3.- Validar la Opción
                    if (seleccion >= NUM_OPCIONES)
                    {
                        throw new OverflowException();
                    }
                }
                catch (FormatException error)
                {
                    esValido = false;
                    mensajeError = "ERROR: Ha introducido caracteres no numéricos";
                }
                catch (OverflowException error)
                {
                    esValido = false;
                    mensajeError = "ERROR: Ha introducido un valor fuera del rango";
                }
                // 4.- Retroalimentación al Usuario
                if (!esValido)
                {
                    Console.WriteLine(mensajeError);
                    Console.Write("Pulse Enter para continuar");
                    Console.ReadLine();
                }

            } while (!esValido);
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

        public static void MostrarDatosCoche(Vehiculo coche)
        {
            Console.Clear();
            Console.WriteLine($"Marca {coche.Marca}");
            Console.WriteLine($"Modelo: {coche.Modelo}");
            Console.WriteLine($"Tipo Vehículo: {coche.Tipo}");
            Console.WriteLine($"`Combustible: {coche.Combustible}");
            Console.WriteLine($"Estado: {coche.Estado}");
            Console.WriteLine($"Precio Contado: {coche.PrecioContado}");
            Console.WriteLine($"Precio Financiado: {coche.PrecioFinanciado}");
            Console.ReadLine();
        }
        #endregion
    }
}
