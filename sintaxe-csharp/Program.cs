//Classe - Csharp - AULA I
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Porque tudo tem um começo... ");

// AULA sobre namespace: Caminho para a classe
// É atravez do namespace que ele vai reconhecer a classe [Pessoa] - using [endereço do namespace da classe]
// Podemos ter duas classes com o mesmo nome, mas, elas devem ter namespaces diferentes

using sintaxe_csharp.Models;

Pessoa p1 = new Pessoa(); //instanciamos


p1.Nome = "Aline";
p1.Idade = 30;
p1.Apresentar();
