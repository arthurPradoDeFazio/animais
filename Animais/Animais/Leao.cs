using System;
namespace Animais
{
	public class Leao : Mamifero
	{
        public override string CorDoPelo { get; init; } = "Amarelo";
        public override bool Carnivoro { get; init; } = true;
        public override bool Peconhento { get; init; } = false;

        public override void Alimentar()
        {
            Console.WriteLine("Leao comendo");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Leao rugindo");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Leao movimentando");
        }
    }
}

