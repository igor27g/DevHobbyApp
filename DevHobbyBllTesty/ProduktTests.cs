﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
			var oczekiwana = "Witaj Biurko {1}: Czerwone biurko";
			//"Witaj " + NazwaProduktu + " {" + ProduktId + " }" + Opis;

			// ACT (dzialaj)
			var aktualna = produkt.PowiedzWitaj();

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);
		}

		[TestMethod()]
		public void PowiedzWitajSparametryzowanyKonstruktorTest()
		{
			// Arrange (zaranzuj test)
			var produkt = new Produkt(1,"Biurko","Czerwone biurko");
			var oczekiwana = "Witaj Biurko {1}: Czerwone biurko";
			//"Witaj " + NazwaProduktu + " {" + ProduktId + " }" + Opis;

			// ACT (dzialaj)
			var aktualna = produkt.PowiedzWitaj();

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);

		}
	}
}