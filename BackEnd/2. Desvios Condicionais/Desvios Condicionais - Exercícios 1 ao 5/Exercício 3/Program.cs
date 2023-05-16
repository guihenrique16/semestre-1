
Console.WriteLine($"Digite o raio: ");
float raio = float.Parse(Console.ReadLine()!);

double diametro = raio * 2 ;
double comprimento = 2 * Math.PI * raio ;
double area = Math.PI * (Math.Pow(raio, 2));

Console.WriteLine($"O diâmetro é {Math.Round(diametro, 5)}, o comprimento é {Math.Round(comprimento, 5)} e a área é {Math.Round(area, 5)}.");

