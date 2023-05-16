using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_aluno_correcao
{
    //Classe
    public class Aluno
    {
        //atributos (caracteristicas) ou propriedades
        public string Nome;
        public string Curso;
        public string Idade;
        public string Rg;
        public bool Bolsista = false;
        public float MediaFinal;
        public float ValorMensalidade;

        //métodos
        public float VerMediaFinal()
        {
            return this.MediaFinal;
        }
        
        public float VerMensalidade()
        {
            float valor;

            if (this.Bolsista == true && this.MediaFinal >= 8)
            {
                return (valor = this.ValorMensalidade * 0.5f);
            }
            else if (this.Bolsista == true && this.MediaFinal >6)
            {
                return (valor = this.ValorMensalidade * 0.5f);
            }
            else
            {
                return valor = this.ValorMensalidade;
            }
        }
    }
}