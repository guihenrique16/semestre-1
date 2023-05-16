
//Faça uma taboado do 1 ao 10

int contador = 0;
int numero = 0;
int resultado = 0;

for (contador = 1; contador <=10; contador++)
{
    for (numero = 1; numero <= 10; numero++)
    {
        resultado = contador*numero;
        Console.WriteLine($"{contador} x {numero} = {resultado}"); 
    }
}
