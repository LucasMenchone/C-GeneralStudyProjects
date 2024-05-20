using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BananaBankConsole
{
    internal class Cliente
    {
        private const int AGENCIA = 0001;

        private string nome;
        public string Nome { get; set; }
   
        private string conta;
        public string Conta { get; set; }

        private decimal saldo;
        public decimal Saldo 
        { 
            get
            {
                return (decimal)saldo;
            }

            set
            {
                if (value <= 0)
                { 
                    saldo = 0;
                } 
                else
                {
                    saldo = value;
                }
            }
        }

        public Cliente(string nome, decimal saldo)
        {
            Nome = nome;
            Saldo = saldo;

            Guid guid = Guid.NewGuid();
            string hexString = BitConverter.ToString(guid.ToByteArray()).Replace("-", "");
            Conta = hexString.Substring(0, 8);
        }

        public void Deposito(decimal valor_deposito)
        {
            if (valor_deposito < 0)
            {
                return;
            }
            else
            {
                Saldo += valor_deposito;
            }
            
        }

        public void Saque(decimal valor_saque) 
        {
            if (valor_saque > Saldo) 
            {
                return;
            }
            else
            {
                Saldo -= valor_saque;

            }
        }

        public void Transferencia(Cliente beneficiario, decimal valor_transferencia)
        {
            if (valor_transferencia > Saldo)
            {
                return;
            }
            else
            {
                Saldo -= valor_transferencia;
                beneficiario.Saldo += valor_transferencia; 
            }
        }

        public void ExibeDados()
        {
            Console.WriteLine($"Dados do Cliente:" +
                            $"\nNome:\t\t{Nome}" +
                            $"\nAgencia:\t\t{AGENCIA}" +
                            $"\nConta:\t\t{Conta}" +
                            $"\nSaldo:\t\t{Saldo.ToString("c")}");
                
        }
    }
}
