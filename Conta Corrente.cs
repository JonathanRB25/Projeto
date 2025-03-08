using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Conta_Corrente
    {
        public double Numero;
        public string Titular;
        public double Saldo;


        public Conta_Corrente(double saldo, string titular, double numero)
        {
            Saldo = saldo; 
            Titular = titular;
            Numero = numero;
        }

        public double GetSaldo()
        {
            return Saldo;
        }

        public void GetSacar(double ValorSacado)
        {
            Saldo = Saldo - ValorSacado;
            
         
            if (Saldo < ValorSacado)
            {
                Console.WriteLine("Valor Insuficiente");
                return 
            }

            return $"Seu saldo atual é {Saldo}";
        }

        public double GetDepositar(double ValorDepositado)
        {
            Saldo = Saldo + ValorDepositado;
            return Saldo;
        }
    }
}
