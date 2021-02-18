using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
	[TestClass]
	public class GestioneTest1
	{
		[TestMethod]
		public void TestDeterminata1()
		{
			double a = 6;
			double b = 5;
			bool valoreGiusto = true;
			bool valoreSbagliato = Equazioni.IsDetermined(a, b);
			Assert.Equals(valoreGiusto, valoreSbagliato);
		}
		public void TestDeterminata2()
		{
			double a = 22;
			double b = 12;
			bool valoreGiusto = true;
			bool valoreSbagliato = Equazioni.IsDetermined(a, b);
			Assert.Equals(valoreGiusto, valoreSbagliato);
		}

		public void IsInconsisted1()
		{
			double a = 0;
			double b = 10;
			bool valoreGiusto = true;
			bool valoreSbagliato = Equazioni.IsInconsisted(a, b);
			Assert.Equals(valoreGiusto, valoreSbagliato);
		}
		public void IsInconsisted2()
		{
			double a = 0;
			double b = 6;
			bool valoreGiusto = true;
			bool valoreSbagliato = Equazioni.IsInconsisted(a, b);
			Assert.Equals(valoreGiusto, valoreSbagliato);

		}
	}
}
