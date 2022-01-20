
int numero = 2;
Console.WriteLine("Digita un numero: ");
numero = Convert.ToInt32(Console.ReadLine());
if ((numero % 2) == 0)
{
    Console.WriteLine($"{numero} es par");
}
else
{
    Console.WriteLine($"{numero} es impar");
}
