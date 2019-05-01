using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevHobby.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevHobby.BLL.Tests
{
	[TestClass()]
	public class ProduktTests
	{
		[TestMethod()]
		public void PowiedzWitajTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt();
			produkt.NazwaProduktu = "Biurko";
			produkt.ProduktId = 1;
			produkt.Opis = "Czerwone biurko";
			produkt.DostawcaProduktu.NazwaFirmy = "DevHobby";
			var oczekiwana = "Witaj Biurko {1}: Czerwone biurko Dostepny od : ";
			//"Witaj " + NazwaProduktu + " {" + ProduktId + " }" + Opis;

			// ACT (dzialaj)
			var aktualna = produkt.PowiedzWitaj();

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}

		[TestMethod()]
		public void PowiedzWitaj_SparametryzowanyKonstruktorTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt(1,"Biurko","Czerwone biurko");
			var oczekiwana = "Witaj Biurko {1}: Czerwone biurko Dostepny od : ";
			//"Witaj " + NazwaProduktu + " {" + ProduktId + " }" + Opis;

			// ACT (dzialaj)
			var aktualna = produkt.PowiedzWitaj();

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);

		}

		[TestMethod()]
		public void PowiedzWitaj_InicjalizatorObiektuTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt
			{
				ProduktId = 1,
			    NazwaProduktu = "Biurko",
				Opis = "Czerwone biurko"
			};



			var oczekiwana = "Witaj Biurko {1}: Czerwone biurko Dostepny od : ";
			//"Witaj " + NazwaProduktu + " {" + ProduktId + " }" + Opis;

			// ACT (dzialaj)
			var aktualna = produkt.PowiedzWitaj();

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);

		}

		[TestMethod()]
		public void Produkt_NullTest()
		{
			// Arrange (zaranzuj test)
			Produkt produkt = null;


			string oczekiwana = null;
			//"Witaj " + NazwaProduktu + " {" + ProduktId + " }" + Opis;

			// ACT (dzialaj)
			var aktualna = produkt?.DostawcaProduktu?.NazwaFirmy;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}


		[TestMethod()]
		public void Konwersja_CaliNaMetrTest()
		{
			// Arrange (zaranzuj test)
			var oczekiwana = 194.35;

			// ACT (dzialaj)
			var aktualna = 5 * Produkt.CaliNaMetr;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}


		[TestMethod()]
		public void MinimalnaCena_DomyslnaTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt();
			var oczekiwana = 10.50m;

			// ACT (dzialaj)
			var aktualna = produkt.MinimalnaCena;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}


		[TestMethod()]
		public void MinimalnaCena_KrzesloTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt(1, "Krzesło obrotowe", "opis");
			var oczekiwana = 120.99m;

			// ACT (dzialaj)
			var aktualna = produkt.MinimalnaCena;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}


	}
}