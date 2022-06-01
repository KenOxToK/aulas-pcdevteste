using System;

namespace AulasPCDev.Models
{
    public class Conta // CONTA
    {
        public int Saldo { get; private set; }

        public string ToString()
        {
            return "R$ " + Saldo + ",00"; // VALOR
        }
        public Conta(int saldoInicial)
        {
            Saldo = saldoInicial;
        }
        public void Deposito(int valor)
        {
            Saldo = Saldo + valor; // +SALDO
        }
        public void Saque(int valor)
        {
            Saldo = Saldo - valor; // -SALDO
        }
    }
}