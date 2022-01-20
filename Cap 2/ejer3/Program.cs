double pi = 3.14f;
double radianes;
Console.WriteLine("Ingresa los grados: ");
double grados = Convert.ToDouble(Console.ReadLine());
radianes = grados * pi / 180;
Console.WriteLine($"{radianes}");
