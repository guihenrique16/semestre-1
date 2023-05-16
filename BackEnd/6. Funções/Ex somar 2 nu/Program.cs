
// Criar método para somar 2 números
int[] numeros = new int[2];

for (var i = 0; i < 2; i++)
{
    Console.WriteLine($"Digite dois números: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

static float Soma(float n1, float n2){
    
    return n1 + n2;
}

Soma(1,4);



// float resultSoma = Soma(16,20);


// Console.WriteLine($"Resultado: {resultSoma}");


// // // Criar método para subtrair 2 números

// static float Subtrair(float n1, float n2){
    
//     return n1 - n2;
// }

// float resultSub = Subtrair(16,20);

// Console.WriteLine($"Resultado: {resultSub}");


// // Criar método para Multiplicar 2 números

// static float Multiplicar(float n1, float n2){
    
//     return n1 * n2;
// }

// float resultMulti = Multiplicar(16,20);

// Console.WriteLine($"Resultado: {resultMulti}");


// // Criar método para Dividir 2 números

// static float Dividir(float n1, float n2){
    
//     float r = n1 / n2; 
//     return r;
// }

// float resultDiv = Dividir(16,20);

// Console.WriteLine($"Resultado: {resultDiv}");