using System;

namespace BibliotecaClasses
{
    public class ContaCorrente : ContaBancaria
    {

        public decimal Saldo
        {
            get { return this.saldo; }
        }

        public ContaCorrente(int numeroConta, decimal saldo, Cliente cliente)
        {
            this.numeroConta = numeroConta;
            this.saldo = saldo;
            this.cliente = cliente;
        }

        public void Sacar(decimal valor)
        {
            if (this.saldo < valor)
            {
                throw new Exception("Saldo insuficiente");
            }

            this.saldo -= valor;
        }
    }
}
