
using System.Globalization;

Console.WriteLine($"Informe sua renda: ");
    float renda = float.Parse(Console.ReadLine()!);

static float ImpostoDeRenda(float imposto){
    
    if(imposto <= 1500)
    {
        Console.WriteLine($"Você está isento de imposto.");
    }
    else if ((imposto >= 1501) && (imposto <= 3500))
    {
        imposto = (imposto/100) * 20;
        Console.WriteLine($"Você vai pagar 20% de imposto. O valor a pagar é {imposto.ToString("C", new CultureInfo("pt-BR"))}");
    }
    else if ((imposto >= 3501) && (imposto <= 6000))
    {
        imposto = (imposto/100) * 25;
        Console.WriteLine($"Você vai pagar 25% de imposto. O valor a pagar é {imposto.ToString("C", new CultureInfo("pt-BR"))}");
    }
    else
    {
        imposto = (imposto/100) * 35;
        Console.WriteLine($"Você vai pagar 35%. O valor a pagar é {imposto.ToString("C", new CultureInfo("pt-BR"))}");
    }

    return 0;
}

ImpostoDeRenda(renda);