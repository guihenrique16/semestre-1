
// string[] carros = new string[3];

// Console.WriteLi+/ne($"Digite o nome do carro: ");
// carros[0] = Console.ReadLine()!;

// Console.WriteLine($"Primeiro carro da lista: {carros[0]}");

string[]carros = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o nome do {i +1}º do carro: ");
    carros[i] = Console.ReadLine()!;
}

for (var i = 0; i < 3; i++)
{
    Console.WriteLine($"O {i +1}º carro é: {carros[i]}");
}

// foreach (var item in carros)
// {
    
// }
