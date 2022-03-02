using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses
{
    public class Funcionario
    {
        private int matricula;
        private string nome;
        private string funcao;
        private decimal salario;

        public Funcionario(string nome, string funcao, decimal salario)
        {
            SetMatricula();
            this.nome = nome;
            this.funcao = funcao;
            this.salario = salario;
        }

        public int Matricula
        {
            get { return this.matricula; }
        }

        public string Nome
        {
            get { return this.nome; }
        }

        public string Funcao
        {
            get { return this.funcao; }
        }

        public decimal Salario
        {
            get { return this.salario; }
        }

        private void SetMatricula()
        {
            Random random = new();

            matricula = random.Next(1, 500);
        }
    }
}
