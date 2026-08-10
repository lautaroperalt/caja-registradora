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
const decimal RecargoCredito = 0.15m;


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
                decimal porcentajeDescuento = 0m;
    
                    if (cantidadTotalVentas > 5000)
                        {
                             porcentajeDescuento = DescuentoMayor;
            }

                    else if (cantidadTotalVentas > 2000)
                        {
                             porcentajeDescuento = DescuentoMenor;
            }

                    else
                        {   
                            Console.WriteLine("No cumple el minimo para descuento");
            }

            decimal descuentoTotal = cantidadTotalVentas * porcentajeDescuento;
            decimal subtotalConDescuento = cantidadTotalVentas - descuentoTotal;
            Console.WriteLine($"Descuento aplicado por monto: (${descuentoTotal}) => {porcentajeDescuento * 100}%");
            
            Console.WriteLine();
Console.WriteLine("Seleccione un medio de pago: ");
Console.WriteLine("1. Efectivo (10% de descuento)"); Console.WriteLine("2. Debito"); Console.WriteLine("2. Credito (15% de recargo)");
string medioDePago = Console.ReadLine();

            decimal ajustePago = 0;

            switch (medioDePago)
            {
                case "1":
                    ajustePago = -(subtotalConDescuento * DescuentoMayor);
                    Console.WriteLine("Pago en efectivo seleccionado, aplicando un 10% adicional de descuento");
                    break;

                case "2":
                    ajustePago = 0m;
                    Console.WriteLine("Pago en debito seleccionado, sin cambios en el precio");
                    break;

                case "3":
                    ajustePago = subtotalConDescuento * RecargoCredito;
                    Console.WriteLine("Pago en credito seleccionado, aplicando un 15% de recargo");
                    break;

                default:
                    Console.WriteLine("Medio de pago invalido");
                    break;
            }
            decimal totalFinal = subtotalConDescuento + ajustePago;

            Console.WriteLine($"Subtotal inicial: ${cantidadTotalVentas}");
            Console.WriteLine($"Descuento por monto: -{DescuentoMayor * 100}%");
            Console.WriteLine($"Ajuste medio de pago: ${ajustePago}");
            Console.WriteLine($"El precio final a pagar es: ${totalFinal}");

            break;

            default:
                Console.WriteLine("Opcion invalida. Intentar nuevamente");
            break;
        }
    }
while (opcion != "2");