
using _1º_exemplo;

//instanciar um objeto
Personagem p1 = new Personagem();

Console.WriteLine($"Informe o nome do personagem: ");
p1.nome = Console.ReadLine()!;

Console.WriteLine($"Informe a idade do personagem: ");
p1.idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe a armadura do personagem: ");
p1.armadura = Console.ReadLine()!;

Console.WriteLine($"Informe a IA do personagem: ");
p1.ia = Console.ReadLine()!;

p1.Atacar();

p1.Defender();

p1.RestaurarArmadura();