using System;
namespace Animais
{
	public class Lontra: Mamifero, IAquatico
	{
		public Lontra()
		{
		}

        public bool ViveEmTerra { get; set; } = true;
        public bool Mergulho { get; set; } = true;
        public bool AguaDoce { get; set; } = true;
        public override string CorDoPelo { get; init; } = "marrom";
        public override bool Carnivoro { get; init; } = true;
        public override bool Peconhento { get; init; } = false;

        public override void Alimentar()
        {
            Console.WriteLine("Lontra comendo");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Lontra se comunicando");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Lontra se movimentando");
        }
    }
}

