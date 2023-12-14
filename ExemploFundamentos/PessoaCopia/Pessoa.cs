using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOFUNDAMENTOS.PessoaCopia
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        
        public void Apresentar() //Apresentar(string @class)
        {
            // É possivel utilizar palavras reservadas desde que utilizando o @ na frente da palavra, porém não é recomendado o uso
            //@class = "teste";
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}