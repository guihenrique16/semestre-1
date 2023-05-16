int contador;
int contadorSexof = 0;
int contadorSexom = 0;
int contadorSFsim = 0;
int contadorSMnao = 0;
int contadorOpiniaoSim = 0;
int contadorOpiniaoNao = 0;
double porcentagemHomem = 0;

for (contador = 1; contador <= 10; contador++)
{
    Console.WriteLine($"Informe seu sexo: (m) (f)");
    char sexo = char.Parse(Console.ReadLine()!);
    if (sexo == 'f')
    {
        contadorSexof++;
    }
    else if (sexo == 'm')
    {
        contadorSexom++;
    }

    Console.WriteLine($"Você gostou do produto lançado? sim/nao");
    string opiniao = Console.ReadLine()!;
    if (opiniao == "sim")
    {
        contadorOpiniaoSim++;

        if (sexo == 'f')
        {
            contadorSFsim++;
        }
    }
    else if (opiniao == "nao")
    {
        contadorOpiniaoNao++;

        if (sexo == 'm')
        {
            contadorSMnao++;
        }
    }



}
// Mulheres que responderam
// Console.WriteLine($"Essa é a quantidade de mulheres que responderam a pesquisa: {contadorSexof}");

// Pessoas que gostaram
Console.WriteLine($"Essa é a quantidade de pessoas que responderam que gostaram: {contadorOpiniaoSim}");

// Pessoas que NÃO gostaram
Console.WriteLine($"Essa é a quantidade de pessoas que responderam que não gostaram: {contadorOpiniaoNao}");

// Mulheres que gostaram
Console.WriteLine($"Essa é a quantidade de mulheres que responderam que gostaram: {contadorSFsim}");

// Homens que responderam não
porcentagemHomem = Math.Round(((double)contadorSMnao/(double)contadorSexom)*100,2) ;

Console.WriteLine($"Essa é a porcetagem de homens que não gostaram: {porcentagemHomem}");








