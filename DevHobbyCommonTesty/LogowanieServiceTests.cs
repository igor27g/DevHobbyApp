using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevHobby.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevHobby.Common.Tests
{
	[TestClass()]
	public class LogowanieServiceTests
	{
		[TestMethod()]
		public void LogowanieTest()
		{

			// Arrange (zaranzuj test)		
			var oczekiwana = "Akcja:Test Akcja";
			

			// ACT (dzialaj)
			var aktualna = LogowanieService.Logowanie("Test Akcja");

			// Assert (potwierdz test)
			Assert.AreEqual(oczekiwana, aktualna);






		}
	}
}