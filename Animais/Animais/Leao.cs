using System;
namespace Animais
{
	public class Leao : Mamifero
	{

        public override void Alimentar()
        {
            Console.WriteLine("Leao comendo");
        }

        public override void Amamentar()
        {
            if (Sexo == 'M')
                throw new ArgumentException("Leao macho não amamenta");
            Console.WriteLine("Leao amamentando");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Leao rugindo");
        }

        public override void Movimentar()
        {
            throw new NotImplementedException();
        }
    }
}

