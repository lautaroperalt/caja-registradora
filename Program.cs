Console.WriteLine("Kiosco NOB");

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
const decimal DescuentoEfectivo = 0.10m;


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
    
                    if (cantidadTotalVentas > 50000)
                        {
                             porcentajeDescuento = DescuentoMayor;
            }

                    else if (cantidadTotalVentas > 20000)
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
Console.WriteLine("1. Efectivo (10% de descuento)"); Console.WriteLine("2. Debito"); Console.WriteLine("3. Credito (15% de recargo)");
string medioDePago = Console.ReadLine();

            decimal montoRecargo = 0;

            switch (medioDePago)
            {
                case "1":
                    descuentoTotal += subtotalConDescuento * DescuentoEfectivo;
                    Console.WriteLine("Pago en efectivo seleccionado, aplicando un 10% adicional de descuento");
                    Console.WriteLine();
                    break;

                case "2":
                    Console.WriteLine("Pago en debito seleccionado, sin cambios en el precio");
                    Console.WriteLine();
                    break;

                case "3":
                    montoRecargo = subtotalConDescuento * RecargoCredito;
                    Console.WriteLine("Pago en credito seleccionado, aplicando un 15% de recargo");
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Medio de pago invalido");
                    break;
            }
            decimal totalFinal = cantidadTotalVentas + montoRecargo - descuentoTotal;

            Console.WriteLine();

            for (int i = 0; i < 30; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
            Console.WriteLine($"Kiosco NOB");
            Console.WriteLine();

            for (int i = 0; i < 30; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine($"Cajero: {nombreCajero}");
            Console.WriteLine($"Productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal: ${cantidadTotalVentas}");
            Console.WriteLine($"Descuento: ${descuentoTotal}");
            Console.WriteLine($"Recargo: ${montoRecargo}");
            
            for (int i = 0; i < 30; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            Console.WriteLine($"Total: ${totalFinal}");
            for (int i = 0; i < 30; i++)
            {
                Console.Write("-");
            }

            break;

            default:
                Console.WriteLine("Opcion invalida. Intentar nuevamente");
            break;
        }
    }
while (opcion != "2");