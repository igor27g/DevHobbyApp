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

		[TestMethod()]
		public void NazwaProduktu_FormatTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt();
			produkt.NazwaProduktu = " Krzesło obrotowe ";
			var oczekiwana = "Krzesło obrotowe";

			// ACT (dzialaj)
			var aktualna = produkt.NazwaProduktu;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}


		[TestMethod()]
		public void NazwaProduktu_ZakrotkaTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt();
			produkt.NazwaProduktu = "Krz";
			string oczekiwana = null;
			string oczekiwanaWiadomosc = "Nazwa produktu musi być dłuższa niż 4 znaki";

			// ACT (dzialaj)
			var aktualna = produkt.NazwaProduktu;
			var aktualnaWiadomosc = produkt.Wiadomosc;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
			Assert.AreEqual(oczekiwanaWiadomosc, aktualnaWiadomosc);
		}


		[TestMethod()]
		public void NazwaProduktu_ZaDlugaTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt();
			produkt.NazwaProduktu = "Krzesło obrotowe zbyt długa nazwa ";
			string oczekiwana = null;
			string oczekiwanaWiadomosc = "Nazwa produktu musi być dłuższa niż 30 znaków";

			// ACT (dzialaj)
			var aktualna = produkt.NazwaProduktu;
			var aktualnaWiadomosc = produkt.Wiadomosc;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
			Assert.AreEqual(oczekiwanaWiadomosc, aktualnaWiadomosc);
		}


		[TestMethod()]
		public void NazwaProduktu_PrawidłowaTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt();
			produkt.NazwaProduktu = "Krzesło obrotowe";
			string oczekiwana = "Krzesło obrotowe";
			string oczekiwanaWiadomosc = null;

			// ACT (dzialaj)
			var aktualna = produkt.NazwaProduktu;
			var aktualnaWiadomosc = produkt.Wiadomosc;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
			Assert.AreEqual(oczekiwanaWiadomosc, aktualnaWiadomosc);
		}

		[TestMethod()]
		public void Kategoria_WartoscDomyslnaTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt();
			string oczekiwana = "Informatyka";

			// ACT (dzialaj)
			var aktualna = produkt.Kategoria;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}

		[TestMethod()]
		public void Kategoria_NowaWartoscTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt();
			produkt.Kategoria = "Geografia";
			string oczekiwana = "Informatyka";

			// ACT (dzialaj)
			var aktualna = produkt.Kategoria;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}

		[TestMethod()]
		public void Numer_WartoscDomyslnaTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt();
			var oczekiwana = 1;

			// ACT (dzialaj)
			var aktualna = produkt.Numer;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}

		[TestMethod()]
		public void Numer_NowaWartoscTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt();
			produkt.Numer = 400;
			var oczekiwana = 400;

			// ACT (dzialaj)
			var aktualna = produkt.Numer;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}


		[TestMethod()]
		public void KodProdutku_wartoscDomyslnaTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt();
			var oczekiwana = "Informatyka - 1";

			// ACT (dzialaj)
			var aktualna = produkt.KodProduktu;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}

		[TestMethod()]
		public void KodProdutku_NowaWartoscTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt();
			produkt.Kategoria = "Historia";
			produkt.Numer = 10;
			var oczekiwana = "Historia - 10";

			// ACT (dzialaj)
			var aktualna = produkt.KodProduktu;

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}


	}
}