namespace RE19_CristobalMC
{
    internal class Concesionario
    {
        static void Main(string[] args)
        {
            #region INSTANCIACIÓN
            // MARCAS VEHICULO
            string renault = "RENAULT";
            string citroen = "CITROEN";
            string ford = "FORD";
            string peugeot = "PEUGEOT";
            string volkswagen = "VOLKSWAGEN";
            // MODELOS VEHICULOS
            string clio = "CLIO";
            string cactus = "CACTUS";
            string focus = "FOCUS";
            string p308 = "P308";
            string golf = "GOLF";


            Vehiculo Vehiculo1;
            Vehiculo1 = new Vehiculo(renault, clio);
            Vehiculo1.Marca = renault;
            Vehiculo1.Modelo = clio;

            Vehiculo Vehiculo2;
            Vehiculo2 = new Vehiculo(citroen, cactus);
            Vehiculo2.Marca = citroen;
            Vehiculo2.Modelo = cactus;

            Vehiculo Vehiculo3;
            Vehiculo3 = new Vehiculo(ford, focus);
            Vehiculo3.Marca = ford;
            Vehiculo3.Modelo = focus;

            Vehiculo Vehiculo4;
            Vehiculo4 = new Vehiculo(peugeot, p308);
            Vehiculo4.Marca = peugeot;
            Vehiculo4.Modelo = p308;

            Vehiculo Vehiculo5;
            Vehiculo5 = new Vehiculo(volkswagen, golf);
            Vehiculo5.Marca = volkswagen;
            Vehiculo5.Modelo = golf;
            #endregion
            #region EJECUCIÓN
            byte consola;
            byte consola2;
            string aux;
            byte fin = 0;
            do
            {
                Console.WriteLine("1: Ver lista de vehículos");
                Console.WriteLine("2: Ver datos de vehículos");
                Console.WriteLine("3: Fin");
                aux = Console.ReadLine();
                consola = Convert.ToByte(aux);
                switch (consola)
                {
                    case 1:
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine($"Marca: {Vehiculo1.Marca}");
                        Console.WriteLine($"Modelo: {Vehiculo1.Modelo}");
                        Console.WriteLine($"Tipo: {Vehiculo1.Tipo}");
                        Console.WriteLine($"Combustible: {Vehiculo1.Combustible}");
                        Console.WriteLine($"Estado: {Vehiculo1.Estado}");
                        Console.WriteLine($"Precio: {Vehiculo1.Precio}");
                        Console.WriteLine($"Precio Financiado: {Vehiculo1.PrecioFinanciado}");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine($"Marca: {Vehiculo2.Marca}");
                        Console.WriteLine($"Modelo: {Vehiculo2.Modelo}");
                        Console.WriteLine($"Tipo: {Vehiculo2.Tipo}");
                        Console.WriteLine($"Combustible: {Vehiculo2.Combustible}");
                        Console.WriteLine($"Estado: {Vehiculo2.Estado}");
                        Console.WriteLine($"Precio: {Vehiculo2.Precio}");
                        Console.WriteLine($"Precio Financiado: {Vehiculo2.PrecioFinanciado}");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine($"Marca: {Vehiculo3.Marca}");
                        Console.WriteLine($"Modelo: {Vehiculo3.Modelo}");
                        Console.WriteLine($"Tipo: {Vehiculo3.Tipo}");
                        Console.WriteLine($"Combustible: {Vehiculo3.Combustible}");
                        Console.WriteLine($"Estado: {Vehiculo3.Estado}");
                        Console.WriteLine($"Precio: {Vehiculo3.Precio}");
                        Console.WriteLine($"Precio Financiado: {Vehiculo3.PrecioFinanciado}");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine($"Marca: {Vehiculo4.Marca}");
                        Console.WriteLine($"Modelo: {Vehiculo4.Modelo}");
                        Console.WriteLine($"Tipo: {Vehiculo4.Tipo}");
                        Console.WriteLine($"Combustible: {Vehiculo4.Combustible}");
                        Console.WriteLine($"Estado: {Vehiculo4.Estado}");
                        Console.WriteLine($"Precio: {Vehiculo4.Precio}");
                        Console.WriteLine($"Precio Financiado: {Vehiculo4.PrecioFinanciado}");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine($"Marca: {Vehiculo5.Marca}");
                        Console.WriteLine($"Modelo: {Vehiculo5.Modelo}");
                        Console.WriteLine($"Tipo: {Vehiculo5.Tipo}");
                        Console.WriteLine($"Combustible: {Vehiculo5.Combustible}");
                        Console.WriteLine($"Estado: {Vehiculo5.Estado}");
                        Console.WriteLine($"Precio: {Vehiculo5.Precio}");
                        Console.WriteLine($"Precio Financiado: {Vehiculo5.PrecioFinanciado}");
                        Console.WriteLine("-----------------------------------------------");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Escoja el vehículo que desea ver");
                        Console.WriteLine($"1.{Vehiculo1.Marca} { Vehiculo1.Modelo}");
                        Console.WriteLine($"2.{Vehiculo2.Marca} {Vehiculo2.Modelo}");
                        Console.WriteLine($"3.{Vehiculo3.Marca} {Vehiculo3.Modelo}");
                        Console.WriteLine($"4.{Vehiculo4.Marca} {Vehiculo4.Modelo}");
                        Console.WriteLine($"5.{Vehiculo5.Marca} {Vehiculo5.Modelo}");
                        aux = Console.ReadLine();
                        consola2 = Convert.ToByte(aux);
                        switch (consola2)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine($"Marca: {Vehiculo1.Marca}");
                                Console.WriteLine($"Modelo: {Vehiculo1.Modelo}");
                                Console.WriteLine($"Tipo: {Vehiculo1.Tipo}");
                                Console.WriteLine($"Combustible: {Vehiculo1.Combustible}");
                                Console.WriteLine($"Estado: {Vehiculo1.Estado}");
                                Console.WriteLine($"Precio: {Vehiculo1.Precio}");
                                Console.WriteLine($"Precio Financiado: {Vehiculo1.PrecioFinanciado}");
                                Console.WriteLine("-----------------------------------------------");
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine($"Marca: {Vehiculo2.Marca}");
                                Console.WriteLine($"Modelo: {Vehiculo2.Modelo}");
                                Console.WriteLine($"Tipo: {Vehiculo2.Tipo}");
                                Console.WriteLine($"Combustible: {Vehiculo2.Combustible}");
                                Console.WriteLine($"Estado: {Vehiculo2.Estado}");
                                Console.WriteLine($"Precio: {Vehiculo2.Precio}");
                                Console.WriteLine($"Precio Financiado: {Vehiculo2.PrecioFinanciado}");
                                Console.WriteLine("-----------------------------------------------");
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine($"Marca: {Vehiculo3.Marca}");
                                Console.WriteLine($"Modelo: {Vehiculo3.Modelo}");
                                Console.WriteLine($"Tipo: {Vehiculo3.Tipo}");
                                Console.WriteLine($"Combustible: {Vehiculo3.Combustible}");
                                Console.WriteLine($"Estado: {Vehiculo3.Estado}");
                                Console.WriteLine($"Precio: {Vehiculo3.Precio}");
                                Console.WriteLine($"Precio Financiado: {Vehiculo3.PrecioFinanciado}");
                                Console.WriteLine("-----------------------------------------------");
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine($"Marca: {Vehiculo4.Marca}");
                                Console.WriteLine($"Modelo: {Vehiculo4.Modelo}");
                                Console.WriteLine($"Tipo: {Vehiculo4.Tipo}");
                                Console.WriteLine($"Combustible: {Vehiculo4.Combustible}");
                                Console.WriteLine($"Estado: {Vehiculo4.Estado}");
                                Console.WriteLine($"Precio: {Vehiculo4.Precio}");
                                Console.WriteLine($"Precio Financiado: {Vehiculo4.PrecioFinanciado}");
                                Console.WriteLine("-----------------------------------------------");
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine($"Marca: {Vehiculo5.Marca}");
                                Console.WriteLine($"Modelo: {Vehiculo5.Modelo}");
                                Console.WriteLine($"Tipo: {Vehiculo5.Tipo}");
                                Console.WriteLine($"Combustible: {Vehiculo5.Combustible}");
                                Console.WriteLine($"Estado: {Vehiculo5.Estado}");
                                Console.WriteLine($"Precio: {Vehiculo5.Precio}");
                                Console.WriteLine($"Precio Financiado: {Vehiculo5.PrecioFinanciado}");
                                Console.WriteLine("-----------------------------------------------");
                                break;
                        }
                        break;
                    case 3:
                        fin = 1;
                        break;
                }
            } while (fin == 0);
            #endregion
            }
    }
    }