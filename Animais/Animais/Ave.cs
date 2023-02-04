using System;
namespace Animais
{
	public abstract class Ave : Animal, IOviparo
	{
		public bool Rapina { get; init; }
		public bool CorPena { get; init; }

        public void Botar()
        {
            if (Sexo == 'M')
                throw new ArgumentException("Macho não bota ovo");
            Console.WriteLine("Botando ovo");
        }

        public abstract void Chocar();
        public abstract void Ciscar();
	}
}

