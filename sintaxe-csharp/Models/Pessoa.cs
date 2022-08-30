using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Classes são definidas com a primeira letra maiuscula
//namespace: organização
namespace sintaxe_csharp.Models
{
    //Classe Pessoa
    public class Pessoa //classe
    {
       //[atalho]prop: vai gerar atributos: Nome e Idade
        public string? Nome { get; set; }
        public int Idade { get; set; }

        //Metodo: Ação que a pessoa pode realizar

        public void Apresentar() //metodo
        {
            //Console = classe | WriteLine = metodo
            Console.WriteLine($"Hello, World!!\nMe chamo {Nome}, tenho {Idade} anos de idade.\nE esse é o meu primeiro código em C#.");

            // DICAS:
            //Quando se utiliza o @[palavra reservada]informamos que sabemos que é uma palavra reservada mais quero utiliza-la mesmo assim
            // o [/n : Pode-se quebrar de linha]

           //Pra variaveis: camelCase
          // Evitar abreviações 
          // O nome do arquivo deve obedecer o nome da classe
        }
        
    }
}