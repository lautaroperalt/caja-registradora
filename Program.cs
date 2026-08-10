Console.WriteLine("Kiosco de NOB");

Console.Write("Ingrese el nombre del cajero: ");
string nombreCajero = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Bienvenido, {nombreCajero}. Caja abierta");

//las variables para ir acumulando ( se tienen que poner afuera del bucle)
decimal cantidadTotalVentas = 0;
int cantidadProductos = 0;
string opcion;

do 
{
    Console.WriteLine("Que desea hacer?");
    Console.WriteLine("1. Cargar un producto"); Console.WriteLine("2. Cerrar la venta"); Console.WriteLine("Seleccione una opcion");
    opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.WriteLine("Nombre del producto que desea agregar? ");
                string nombreProducto = Console.ReadLine();

                Console.Write("Ingrese su precio: ");
                decimal precioProducto = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"Producto '{nombreProducto}' agregado exitosamente, y su respectivo precio de {precioProducto} pesos");
            Console.WriteLine();
                cantidadProductos ++;
                cantidadTotalVentas += precioProducto;
                
                break;

            case "2":
                Console.WriteLine("Cerrando caja... Resumen ventas: ");
            Console.WriteLine($"Cantidad de productos agregados {cantidadProductos}");
            Console.WriteLine($"Total ventas {cantidadTotalVentas}");
            break;

            default:
                Console.WriteLine("Opcion invalida. Intentar nuevamente");
                break;
        }
    }
while (opcion != "2");