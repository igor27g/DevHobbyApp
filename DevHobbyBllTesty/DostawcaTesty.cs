using System;
using DevHobby.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevHobbyBllTesty
{
	[TestClass]
	public class DostawcaTesty
	{
		[TestMethod]
		public void WyslijEmailWitamy_PrawidlowaNazwaFirmy_Sukces()
		{
			//Arrange (zaranzuj test)
			var dostawca = new Dostawca();
			dostawca.NazwaFirmy = "DevHobby";
			var wartoscOczekiwana = "Wiadomosc wyslana: Witaj DevHobby";

			//ACT (dzialaj)
			var wartoscAktualna = dostawca.WyslijEmailWitamy("Wiadomosc testowa");

			//Assert (potwierdz test)
			Assert.AreEqual(wartoscOczekiwana, wartoscAktualna);
		}

		[TestMethod]
		public void WyslijEmailWitamy_PustaNazwaFirmy_Sukces()
		{
			//Arrange (zaranzuj test)
			var dostawca = new Dostawca();
			dostawca.NazwaFirmy = "";
			var wartoscOczekiwana = "Wiadomosc wyslana: Witaj";

			//ACT (dzialaj)
			var wartoscAktualna = dostawca.WyslijEmailWitamy("Wiadomosc testowa");

			//Assert (potwierdz test)
			Assert.AreEqual(wartoscOczekiwana, wartoscAktualna);
		}

		[TestMethod]
		public void WyslijEmailWitamy_NullNazwaFirmy_Sukces()
		{
			//Arrange (zaranzuj test)
			var dostawca = new Dostawca();
			dostawca.NazwaFirmy = null;
			var wartoscOczekiwana = "Wiadomosc wyslana: Witaj";

			//ACT (dzialaj)
			var wartoscAktualna = dostawca.WyslijEmailWitamy("Wiadomosc testowa");

			//Assert (potwierdz test)
			Assert.AreEqual(wartoscOczekiwana, wartoscAktualna);
		}



	}
}
