using System;

namespace EquazioniLibrary
{
	public class Equazioni
	{
		public static bool IsDetermined( double a, double b)
		{
			bool determinata = false;
			if (a != 0)
			{
				if (b!=0)
				{
					determinata = true;
             	}

			}
			return determinata;
			
		}

		public static bool IsInconsisted(double a, double b)
		{
			bool determinata = false;
			if (a == 0)
			{
				if (b != 0)
				{
					determinata = true;
				}

			}
			return determinata;

		}


	}
}
