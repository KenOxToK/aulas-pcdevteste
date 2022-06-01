using AulasPCDev.Models;
using AulasPCDev.Services;
using System;
using System.Collections.Generic;

namespace AulasPCDev
{
    public class Program
    {
        private static UsuarioServices _usuarioServices = new UsuarioServices();
        private static GestaoServices _gestaoItens = new GestaoServices();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a locadora de vídeos na loja de Thiago Kenj"); // É minha empresa ^-^

            bool continuar = true;
            do
            {
                Console.WriteLine("Digite o número da sua opção:"); // Digite o número no ordem 
                Console.WriteLine("1 - Cadastrar usuários"); // Cadastrar usuários
                Console.WriteLine("2 - Listar usuários"); // Listar usuários
                Console.WriteLine("3 - Cadastrar filme/série"); // Cadastrar filme/série
                Console.WriteLine("4 - Alugar filme/série"); // Alugar filme/série
                Console.WriteLine("5 - Devolver filme/série"); // Devolver filme/série
                Console.WriteLine("Qualquer outro número para sair ou ALT + F4"); // Fechado na janela de cmd 

                int resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        _usuarioServices.CadastrarUsuario(); // Referenciar CadastrarUsuario
                        break;
                    case 2:
                        _usuarioServices.ListarUsuarios(); // Referenciar ListarUsuario
                        break;
                    case 3:
                        _gestaoItens.Cadastrar(); // Referenciar Cadastrar 
                        break;
                    default:
                        continuar = false;
                        break;
                }
            } while (continuar);

        }
    }
}