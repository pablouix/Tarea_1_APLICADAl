
int prerimetro = 0;

Console.WriteLine("Dijita cantidad de lados: ");
int cantidadLados = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digita valor de lado: ");
int lado = Convert.ToInt32(Console.ReadLine());
prerimetro = cantidadLados * lado;
Console.WriteLine($"El perimetro es: {prerimetro}");
