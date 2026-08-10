Console.WriteLine("Kiosco de NOB");

Console.Write("Ingrese el nombre del cajero: ");
string nombreCajero = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Bienvenido, {nombreCajero}. Caja abierta");

Console.WriteLine("Nombre del producto que desea agregar? ");
string nombreProducto = Console.ReadLine();
Console.Write("Ingrese su precio: ");
int precioProducto = Console.ReadLine();

decimal precioActualizado = decimal.Parse(precioProducto());

Console.Write($"El nombre es: {nombreProducto}, y su respectivo precio: {precioProducto}");