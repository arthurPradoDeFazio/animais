using System;
namespace Animais
{
    public abstract class Reptil : Animal, IOviparo
    {
        public bool TemEscamas { get; init; }
        public bool TemCasco { get; set; }

        public abstract void Chocar();

        public void Botar()
        {
            if (Sexo == 'M')
                throw new ArgumentException("Macho não bota ovo");
            Console.WriteLine("Botando ovo");
        }
    }
}

