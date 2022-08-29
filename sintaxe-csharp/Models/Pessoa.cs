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
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");

            //Quando se utiliza o @[palavra reservada]informamos que sabemos que é uma palavra reservada mais quero utiliza-la mesmo assim

        }
        
    }
}