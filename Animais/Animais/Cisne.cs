using System;
namespace Animais
{
    public class Cisne : Ave, IOviparo, IVoar
    {
        public int AltitudeMaximaEmMetros { get; init; }
        public double VelocidadeDeVoo { get; set; }
        public override bool Carnivoro { get; init; } = false;
        public override bool Peconhento { get; init; } = false;

        public override void Alimentar()
        {
            Console.WriteLine("Cisne comendo");
        }

        public override void Chocar()
        {
            Console.WriteLine("Cisne chocando ovo");
        }

        public override void Ciscar()
        {
            Console.WriteLine("Cisne ciscando");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Cisne se comunicando");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Cisne se movimentando");
        }

        public void Voar()
        {
            Console.WriteLine("Cisne voando");
        }
    }
}

