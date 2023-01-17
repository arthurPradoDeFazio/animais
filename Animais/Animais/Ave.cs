using System;
namespace Animais
{
	public abstract class Ave : Animal, IOviparo
	{
		public bool Rapina { get; init; }
		public bool CorPena { get; init; }

		public abstract void Botar();
		public abstract void Chocar();
        public abstract void Ciscar();
	}
}

