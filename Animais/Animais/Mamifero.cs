using System;
namespace Animais
{
	public abstract class Mamifero : Animal
	{
		public int QuantidadeDeMamas { get; init; }
		public bool Pelos { get; init; }
		public string CorDoPelo { get; init; }

		public abstract void Amamentar();
	}
}



