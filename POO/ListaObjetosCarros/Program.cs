// Criar um projeto de console
// Criar uma classe Carro
// - Marca
// - Cor
// Criar contrutor vazio e completo
// Receber dados no console apara adicionar 2 objetos em uma lista
// Exibir os dois objetos da lista no console

using ListaObjetosCarros;

string marca;
string cor;

List<Carro> carros = new List<Carro>();

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Qual a marca do carro");
    marca = Console.ReadLine()!;


    Console.WriteLine($"Qual a cor do carro");
    cor = Console.ReadLine()!;
    carros.Add(
        new Carro(marca, cor)
    );
}

foreach (var item in carros)
{
    Console.WriteLine(@$"
    Marca do carro: {item.Marca}
    Cor do carro: {item.Cor}
    ");
}
