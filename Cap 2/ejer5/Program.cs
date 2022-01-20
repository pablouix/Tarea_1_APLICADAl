Console.WriteLine("Menu");
Console.WriteLine("1. Dolar a euro.");
Console.WriteLine("2. Euro a dolar.");
Console.WriteLine("3. Salir.");
Console.WriteLine("Opcion: ");
double dolar, euro;
int opcion = Convert.ToInt32(Console.ReadLine());
switch (opcion)
{
    case 1:
        Console.WriteLine("Digita los dolares: ");
        dolar = Convert.ToDouble(Console.ReadLine());
        euro = dolar * 0.88;
        Console.WriteLine($"Dolar {dolar:N2} en euro {euro:N2}");
        break;
    case 2:
        Console.WriteLine("Digita los Euros: ");
        euro = Convert.ToDouble(Console.ReadLine());
        dolar = euro * 1.14;
        Console.WriteLine($"Euro {euro:N2} en dolar {dolar:N2}");
        break;
    default:
        break;
}