using System;
namespace Animais
{
	public class Ornitorrinco: Mamifero, IAquatico, IOviparo
	{
		public Ornitorrinco()
		{
		}

        public bool ViveEmTerra { get; set; } = true;
        public bool Mergulho { get; set; } = true;
        public bool AguaDoce { get; set; } = true;
        public override string CorDoPelo { get; init; } = "marrom";
        public override bool Carnivoro { get; init; } = true;
        public override bool Peconhento { get; init; }

        public override void Alimentar()
        {
            Console.WriteLine("Ornitorrinco comendo");
        }

        public void Botar()
        {
            if (Sexo == 'M')
                throw new ArgumentException("Macho não bota ovo");
            Console.WriteLine("Ornitorrinco botando ovo");
        }

        public void Chocar()
        {
            Console.WriteLine("Ornitorrinco botando ovo");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Ornitorrinco se comunicando");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Ornitorrinco se movimentando");
        }
    }
}

