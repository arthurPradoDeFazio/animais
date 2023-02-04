using System;
namespace Animais
{
	public class Pinguim: Ave, IAquatico
	{
		public Pinguim()
		{
		}

        public override bool Carnivoro { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
        public override bool Peconhento { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Alimentar()
        {
            throw new NotImplementedException();
        }

        public override void Chocar()
        {
            throw new NotImplementedException();
        }

        public override void Ciscar()
        {
            throw new NotImplementedException();
        }

        public override void Comunicar()
        {
            throw new NotImplementedException();
        }

        public override void Movimentar()
        {
            throw new NotImplementedException();
        }
    }
}

