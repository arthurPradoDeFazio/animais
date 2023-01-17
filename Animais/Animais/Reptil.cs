using System;
namespace Animais
{
    public abstract class Reptil : Animal, IOviparo
    {
        public bool TemEscamas { get; init; }
        public bool TemCasco { get; set; }

        public abstract void Botar();
        public abstract void Chocar();
    }
}

