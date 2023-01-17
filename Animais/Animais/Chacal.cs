using System;
namespace Animais
{
	public class Chacal : Mamifero
	{
        public override string CorDoPelo { get; init; } = "Amarelo";
        public override bool Carnivoro { get; init; } = true;
        public override bool Peconhento { get; init; } = false;

        public override void Alimentar()
        {
            Console.WriteLine("Chacal comendo");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Chacal se comunicando");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Chacal movimentando");
        }
    }
}

