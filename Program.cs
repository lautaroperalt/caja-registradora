Console.WriteLine("Kiosco de NOB");

Console.Write("Ingrese el nombre del cajero: ");
string nombreCajero = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Bienvenido, {nombreCajero}. Caja abierta");

//las variables para ir acumulando ( se tienen que poner afuera del bucle)
decimal cantidadTotalVentas = 0;
int cantidadProductos = 0;
string opcion;
const decimal DescuentoMayor = 0.10m;
const decimal DescuentoMenor = 0.10m;


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
                    Console.WriteLine("Resumen ventas: ");
                Console.WriteLine($"Cantidad de productos agregados {cantidadProductos}");
                Console.WriteLine($"Subtotal de ventas {cantidadTotalVentas}");

                    if (cantidadTotalVentas > 5000)
                        {
                            cantidadTotalVentas -= cantidadTotalVentas * DescuentoMayor;
                            Console.WriteLine($"El total a pagar es {cantidadTotalVentas}, con un descuento del 10% aplicado");
                        }

                    else if (cantidadTotalVentas < 5000 && cantidadTotalVentas > 2000)
                        {
                            cantidadTotalVentas -= cantidadTotalVentas * DescuentoMenor;
                            Console.WriteLine($"El total es {cantidadTotalVentas}, con un descuento del 5% aplicado");
                        }

                    else if (cantidadTotalVentas < 2000)
                        {   
                            Console.WriteLine("No cumple el minimo para descuento");
                        }
            break;

            default:
                Console.WriteLine("Opcion invalida. Intentar nuevamente");
                break;
        }
    }
while (opcion != "2");