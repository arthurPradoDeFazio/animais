using System;
namespace Animais
{
	public abstract class Mamifero : Animal
	{
		public int QuantidadeDeMamas { get; init; }
		public bool Pelos { get; init; }
		public abstract string CorDoPelo { get; init; }

		public void Amamentar()
		{
			if (Sexo == 'M')
				throw new ArgumentException("Macho não amamenta");
			Console.WriteLine("Amamentando");
		}
	}
}



