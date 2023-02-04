using System;
namespace Animais
{
	public abstract class Animal
	{
		public string Nome { get; init; }
		public DateTime DataDeNascimento { get; init; }
		public char Sexo { get; private set; }
		public int Idade { get; private set; }
		public abstract bool Carnivoro { get; init; }
		public abstract bool Peconhento { get; init; }

		public abstract void Movimentar();
		public abstract void Comunicar();
		public abstract void Alimentar();

	}
}