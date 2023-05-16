
int[]num = new int [5];

for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o {i +1} numero: ");
    num[i] = int.Parse(Console.ReadLine()!); 
}



// for (var i = 0; i < 5; i++)
// {
//     Console.WriteLine($"O dobro do {i +1}º é: {num[i]*2}");
    
// }

foreach (var item in num)
{
    Console.WriteLine($"O dobro do número informado é: {item * 2}");
}