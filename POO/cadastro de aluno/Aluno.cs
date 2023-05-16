using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_de_aluno
{
    public class Aluno
    {
        public string nome = "";
        public string curso = "";
        public string idade = "";
        public string rg = "";
        public string bolsista = "";
        public float mediaFinal;
        public float valorMensalidade;
        public float valorMensalidadeFinal;

        public float VerMensalidade(float mediaFinal)
        {

            if (mediaFinal >= 8)
            {
                valorMensalidadeFinal = valorMensalidade * 0.50f;
                return valorMensalidadeFinal;
            }
            else if (mediaFinal >= 6 && mediaFinal < 8)
            {
                valorMensalidadeFinal = valorMensalidade * 0.70f;
                return valorMensalidadeFinal;
            }
            return valorMensalidadeFinal;


        }
        public float VerMediaFinal()
        {
            return this.mediaFinal;
        }

    }
}