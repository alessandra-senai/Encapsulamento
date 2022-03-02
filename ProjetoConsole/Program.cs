using BibliotecaClasses;
using System;

namespace ProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Funcionario funcionario = new Funcionario("José Silva", "Diretor", 16453.45M);

            Console.WriteLine("------------- FUNCIONÁRIO --------------");
            Console.WriteLine($"funcionário nome = {funcionario.Nome}");
            Console.WriteLine($"funcionário função = {funcionario.Funcao}");
            Console.WriteLine($"funcionário salário = {funcionario.Salario}");
            Console.WriteLine("----------------------------------------------");

            Cliente cliente = new Cliente("Maria Santos", "456.543.55-5", "45.432.432-09", "Rua Azul, 45 - SP");
            ContaCorrente contaCorrente = new  ContaCorrente(432, 400.00M, cliente);

             contaCorrente.Sacar(10.00M);

            Console.WriteLine("------------- CONTA CORRENTE --------------");
            Console.WriteLine($"saldo atual da conta: {contaCorrente.Saldo} ");
            Console.WriteLine("----------------------------------------------");



        }
    }
}
