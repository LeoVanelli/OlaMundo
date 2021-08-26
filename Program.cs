using System;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 2 - Faça um programa que exiba Olá usuário, eu me chamo Ermogenes! (utilize o seu nome).

            Console.Write("Digite seu nome: ");
            string userName = Console.ReadLine(); // Armazena o nome do usuário que está operando o programa.

            Console.WriteLine($"Olá {userName}, eu me chamo Leandro!"); // Resolução da tarefa.

            Console.Write("Pressione qualquer tecla para fechar. . . "); // Aguarda o usuário fechar o programa ou inserir uma tecla.
            Console.ReadKey();
        }
    }
}
