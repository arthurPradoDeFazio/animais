using System;
namespace Animais
{
	public class Morcego : Mamifero, IVoar
	{
		public Morcego()
		{
		}

        public override string CorDoPelo { get; init; } = "Preto";
        public override bool Carnivoro { get; init; }
        public override bool Peconhento { get; init; } = false;
        public int AltitudeMaximaEmMetros { get; init; }
        public double VelocidadeDeVoo { get; set; }

        public override void Alimentar()
        {
            Console.WriteLine("Morcego comendo");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Morcego se comunicando");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Morcego se movimentando");
        }

        public void Voar()
        {
            Console.WriteLine("Morcego voando");
        }
    }
}

