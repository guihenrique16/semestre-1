using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CambioDeMoedas
{
    public static class Conversao
    {
        public static float Real { get; set; }
        public static float Dolar { get; set; }

        public static float DolarToReal(float Valor)
        {
            Valor = Valor * 4.99f;
            return Valor;
        }
        public static float RealToDolar(float Valor)
        {
            Valor = Valor / 4.99f;
            return Valor;
        }
    }
}