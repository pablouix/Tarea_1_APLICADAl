
Console.WriteLine("Digita los grados centigrados: ");
double gradosCentigrados = Convert.ToDouble(Console.ReadLine());
double gradosFahrenheit = (gradosCentigrados * 9 / 5) + (32);
Console.WriteLine($"Centigrados: {gradosCentigrados} en Fahrenheit: {gradosFahrenheit}");
