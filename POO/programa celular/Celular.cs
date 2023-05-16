using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programa_celular
{
    public class Celular
    {
        // Atributos
        //  cor, modelo, tamanho, ligado(booleano)

        public string Cor;
        public string Modelo;
        public string Tamanho;
        public bool Ligado;

        // Métodos
        //  ligar, desligar, fazer ligação, enviar mensagem
        public bool Ligar()
        {
            return this.Ligado;
        }
        
        public bool Desligar()
        {
            return this.Ligado;
        }

        public void FazerLigacao()
        {
            Console.WriteLine($"Chamando...");
        }

        public void EnviarMensagem()
        {
            Console.WriteLine($"Enviando mensagem...");
        }
    }
}