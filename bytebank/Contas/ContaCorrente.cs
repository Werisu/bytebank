using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int totalDeContasCriadas { get; private set; }
        public ContaCorrente(int numero_agencia, string conta, double saldo, Cliente titular)
        {
            this.numero_agencia = numero_agencia;
            this.conta = conta;
            this.saldo = saldo;
            this.titular = titular;

            totalDeContasCriadas++;
        }

        public int numero_agencia { get; private set; }
        public string conta { get; private set; }
        public double saldo { get; private set; }
        public Cliente titular { get; private set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
    }
}
