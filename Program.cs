using System;

namespace aulapcdev
{
    internal class Program // Thiago Kenj
    {
        static void Main(string[] args) // exercíco 2 
        {
            Console.WriteLine("Bem vindo no site do Thiago Kenj");
            Console.WriteLine("As paginas você deseja acessar?");
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Cadastrar filme/série");
            Console.WriteLine("4 - Alugar filme/série");
            Console.WriteLine("5 - Devolver filme/série");
            Console.WriteLine("Digite o número da opção");

            int numeroDigiado;
            string resposta = Console.ReadLine();
            numeroDigiado = int.Parse(resposta);

            if (numeroDigiado == 1) // Opção de 1 - Cadastrar  
            {
                Console.WriteLine("Página de Cadastrar usuário");
            }
            if (numeroDigiado == 2) // Opção de 2 - Listar  
            {
                Console.WriteLine("Página de Listar usuários");
            }
            if (numeroDigiado == 3) // Opção de 3 - Cadastrar 
            {
                Console.WriteLine("Página de Cadastrar filme/série");
            }
            if (numeroDigiado == 4) // Opção de 4 - Alugar 
            {
                Console.WriteLine("Página de Alugar filme/série");
            }
            if (numeroDigiado == 5) // Opção de 5 - Devolver
            {
                Console.WriteLine("Página de Devolver filme/série");
            }
        }
    }
}