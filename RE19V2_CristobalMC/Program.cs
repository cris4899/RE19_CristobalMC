namespace RE19V2_CristobalMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES
            const int NUM_VEHICULOS = 5;

            // RECURSOS
            // Estructura que almacenará los vehículos
            Vehiculo[] concesionario;

            bool salir = false;
            //byte opcion = 0; // 0 .- SALIR
            byte opcion = 1; //TODO: Prueba opción 1 Menú
            // INICIALIZACIÓN
            // 1.- Carga Inicial de Vehículos
            concesionario = new Vehiculo[NUM_VEHICULOS];
            CargaVehiculos(concesionario);
            // 2.- Acciones del Programa

            do
            {
                // ENTRADA
                // 2.1.- Seleccionar la acción a realizar
                opcion = Interfaz.ObtenerOpcionMenu();
                // PROCESO
                // 2.2.- Realizar la acción según la opción seleccionada
                switch (opcion)
                {
                    // 2.2.1.- Salida del Programa
                    case 0:
                        salir = true;
                        break;
                        // 2.2.2.- Mostrar Listado de Vehículos
                    case 1:
                      
                        Controlador.MostrarListado(concesionario);
                        break;
                        // 2.2.3.- Mostrar datos de unVehículo
                    case 2:
                        
                        Controlador.MostrarVehiculo(concesionario);
                        break;
                }
                // SALIDA
            } while (!salir);

        }

        private static void CargaVehiculos(Vehiculo[] lista)
        {
            // RECURSOS
            Vehiculo coche; // NO INSTANCIADO (Null)

            // Cargar Vehículo 1
            coche = new Vehiculo(); // POR DEFECTO SI NO SE MODIFICA
            coche.Marca = "Seat";
            coche.Modelo = "Ibiza";
            coche.PrecioContado = 18500f;

            lista[0] = coche;

            // Cargar Vehículo 2
            coche = new Vehiculo("Ferrari", "Testarrosa");
            coche.PrecioContado = 75000;

            lista[1] = coche;

            // Cargar Vehículo 3
            coche = new Vehiculo("BMW", "M3 460");
            coche.PrecioContado = 60000;

            lista[2] = coche;

            // Cargar Vehículo 4
            coche = new Vehiculo();
            coche.Marca = "Renault";
            coche.Modelo = "Megane";
            coche.PrecioContado = 2000;

            lista[3] = coche;
            // Cargar Vehículo 5
            coche = new Vehiculo("Ford", "Transit");
            coche.PrecioContado = 5800;
            //coche.TipoVehiculo = "FURGONETA";
            coche.Tipo = TipoVehiculos.Furgoneta;
            lista[4] = coche;
        }
    }
}
