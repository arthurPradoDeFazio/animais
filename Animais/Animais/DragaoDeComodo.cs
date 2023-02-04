using System;
namespace Animais
{
	public class DragaoDeComodo : Reptil
	{

        public override bool Carnivoro { get; init; } = true;
        public override bool Peconhento { get; init; } = true;

        public override void Alimentar()
        {
            Console.WriteLine("Dragao comendo");
        }

        public override void Chocar()
        {
            if (Sexo == 'M')
                throw new ArgumentException("Macho não choca ovo");
            Console.WriteLine("Chocando");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Dragao de comodo se comunicando");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Dragao de comodo se comodo");
        }
    }
}

