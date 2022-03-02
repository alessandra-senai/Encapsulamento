namespace BibliotecaClasses
{
	public class Cliente
	{
		public string Nome { get; private set; }
		public string CPF { get; private set; }
		public string RG { get; private set; } 
		public string Endereco { get; private set; }

		public Cliente(string nome, string cpf, string rg, string endereco)
		{
			Nome = nome;
			CPF = cpf;
			RG = rg;
			Endereco = endereco;
		}
	}
}