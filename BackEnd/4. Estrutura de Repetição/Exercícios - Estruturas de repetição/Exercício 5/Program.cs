//total de homens 
//total de mulheres
//média da idade dos homens
//média da idade das mulheres

int contador;
int idade = 0;
int peso = 0;
char sexo;
int contadorHomem = 0;
int contadorMulher = 0;
int mediaHomem = 0;
int mediaHomemTotal = 0;
int mediaMulher = 0;
int mediaMulherTotal = 0;

for (contador = 1; contador <= 5; contador++)
{
    Console.WriteLine($"Informe sua idade: ");
    idade = int.Parse(Console.ReadLine()!);
    
    Console.WriteLine($"Informe sua peso: ");
    peso = int.Parse(Console.ReadLine()!);
    
    Console.WriteLine($"Informe seu sexo: (m) (f)");
    sexo = char.Parse(Console.ReadLine()!);

    if (sexo == 'm')
    {
        contadorHomem++;
        mediaHomem = mediaHomem + idade;
    }
    else if (sexo == 'f')
    {
        contadorMulher++;
        mediaMulher = mediaMulher + idade;
    }

}

Console.WriteLine($"Este é o total de homens: {contadorHomem}");

Console.WriteLine($"Este é o total de mulheres: {contadorMulher}");

mediaHomemTotal = mediaHomem/contadorHomem;

Console.WriteLine($"Essa é a média da idade dos homens: {mediaHomemTotal}");

mediaMulherTotal = mediaMulher/contadorMulher;

Console.WriteLine($"Essa é a média da idade das mulheres: {mediaMulher}");



