﻿using System;
namespace Animais
{
	public abstract class Animal
	{
		public string Nome { get; init; }
		public DateTime DataDeNascimento { get; init; }
		public char Sexo { get; init; }
		public int Idade { get; private set; }
		public bool Carnivoro { get; init; }
		public bool Peconhento { get; init; }

		public abstract void Movimentar();
		public abstract void Comunicar();
		public abstract void Alimentar();

	}
}