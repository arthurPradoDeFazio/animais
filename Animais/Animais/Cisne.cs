using System;
namespace Animais
{
    public class Cisne : Ave, IOviparo, IVoar
    {
        public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
        public double VelocidadeDeVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool Carnivoro { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
        public override bool Peconhento { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }

        public override void Alimentar()
        {
            throw new NotImplementedException();
        }

        public override void Botar()
        {
            if (Sexo == 'M')
                throw new ArgumentException("Macho não bota ovo");
            Console.WriteLine("Botando ovo");
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

