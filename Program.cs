using System;

namespace aula_entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            string NomeDoUsuario;
            string SobreNome;
            string NomeCompleto;

            Console.Write("Por favor, digite seu nome: ");
            NomeDoUsuario = Console.ReadLine();
            
            Console.Write("agora seu sobrenome: ");
            SobreNome = Console.ReadLine();

            NomeCompleto = $"{NomeDoUsuario} {SobreNome}";
            
            Console.WriteLine($"Obrigado, {NomeCompleto}! Presione uma tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine($"Nome de catalogo...: {SobreNome.ToUpper()}, {NomeDoUsuario}");
            Console.WriteLine("enter para finalizar o programa!");
            Console.ReadKey();
        }
    }
}
