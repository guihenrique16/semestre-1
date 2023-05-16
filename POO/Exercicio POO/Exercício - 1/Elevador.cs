using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício___1
{
    public class Elevador
    {
        //Atributos
        public int CapacidadeElevador { get; set; } = 10;
        public int AndarAtual { get; set; } = 0;
        public int TotalDeAndares { get; set; } = 6;
        public int PessoasPresentes { get; set; } = 0;

        //Métodos
        public void Inicializa()
        {
            Console.WriteLine($"O elevador comporta {CapacidadeElevador} pessoas e o prédio tem {TotalDeAndares} andares");
        }

        public int Entrar()
        {
            if (PessoasPresentes >= 10)
            {
                Console.WriteLine($"O elevador está lotado. Espere esvaziar.");

            }
            else
            {
                PessoasPresentes = PessoasPresentes + 1;
                Console.WriteLine($"Você entrou no elevador.");
            }
            return PessoasPresentes;
        }

        public int Sair()
        {
            if (PessoasPresentes > 0)
            {
                PessoasPresentes = PessoasPresentes - 1;
                Console.WriteLine($"Você saiu do elevador.");
            }
            else
            {
                Console.WriteLine($"Não há ninguem no elevador.");  
            }

            return PessoasPresentes;
        }

        public int Subir()
        {
            if (AndarAtual == 6)
            {
                Console.WriteLine($"Não possivel subir, o elevador está no ultimo andar");
            }
            else
            {
                Console.WriteLine(@$"
                Qual andar você deseja:
                O
                1
                2
                3
                4
                5
                6
                ");
                AndarAtual = int.Parse(Console.ReadLine()!);  
            }

            return AndarAtual;
        }

        public int Descer()
        {
            if(AndarAtual == 0)
            {
                Console.WriteLine($"Não é possivel descer. O elevador está no térreo.");
            }
            else
            {
                Console.WriteLine(@$"
                Qual andar você deseja:
                O
                1
                2
                3
                4
                5
                6
                ");
                AndarAtual = int.Parse(Console.ReadLine()!);  
            }

            return AndarAtual;
        }
    }
}