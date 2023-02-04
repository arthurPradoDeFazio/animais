using System;
namespace Animais
{
	public class Arara : Ave, IVoar
	{
		
        public int AltitudeMaximaEmMetros { get; init; }
        public double VelocidadeDeVoo { get; set; }
        public override bool Carnivoro { get; init; } = false;
        public override bool Peconhento { get; init; } = false;

        public override void Alimentar()
        {
            Console.WriteLine("Arara comendo");
        }

        public override void Chocar()
        {
            if (Sexo == 'M')
                throw new ArgumentException("Macho não choca ovo");
            Console.WriteLine("Arara chocando ovo");
        }

        public override void Ciscar()
        {
            throw new ArgumentException("Arara não cisca");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Arara se comunicando");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Arara se comunicando");
        }

        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}

