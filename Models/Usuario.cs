using System;
using System.Collections.Generic;
using System.Text;

namespace AulasPCDev.Models
{
    public class Usuario // USUÁRIO 
    {
        private readonly static int IDADE_MAIORIDADE = 18; // SÓ ACESSAR QUEM TIVER 18 ANOS A CIMA
        public Usuario(int idade)
        {
            if (idade >= IDADE_MAIORIDADE)
            {
                Idade = idade;
                Conta = new Conta(50);
            }
            else
            {
                throw new Exception();
            }
        }
        public int Idade;
        public string Nome;
        public Conta Conta;
    }
}