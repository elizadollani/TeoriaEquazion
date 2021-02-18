using System;

namespace EquazioniLibrary
{
	public class Equazioni
	{
		public static bool IsDetermined( double a, double b)
		{
			bool determinata;
			if (a != 0)
			{
				determinata = true;
				return true;

			}
			else
			{
				determinata = false;
				return false;

			}
		}

	}
}
