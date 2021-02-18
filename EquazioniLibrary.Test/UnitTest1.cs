using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestDeterminata()
		{
			double a = 6;
			double b = 5;
			bool detrminata = Equazioni.IsDetermined(a, b);
		}
	}

}
