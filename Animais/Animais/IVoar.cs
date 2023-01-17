using System;
namespace Animais
{
	public interface IVoar
	{
		public int AltitudeMaximaEmMetros { get; init; }
		public double VelocidadeDeVoo { get; set; }

		public abstract void Voar();
	}
}

