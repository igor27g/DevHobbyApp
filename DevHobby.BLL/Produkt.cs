using DevHobby.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevHobby.BLL
{
	/// <summary>
	/// Zarzadza produktami
	/// </summary>
	public class Produkt
	{
		public const double CaliNaMetr = 38.87;
		public readonly decimal MinimalnaCena;

		#region Constructors
		public Produkt()
		{
			Console.WriteLine("Produkt został utworzony");
			//this.DostawcaProduktu = new Dostawca();
			this.MinimalnaCena = 10.50m;
		}

		public Produkt(int produktId, string nazwaProduktu, string opis)  : this()
		{
			this.ProduktId = produktId;
			this.NazwaProduktu = nazwaProduktu;
			this.Opis = opis;
			if (nazwaProduktu.StartsWith("Krzesło"))
			{
				this.MinimalnaCena = 120.99m;
			}
			Console.WriteLine("Produkt ma nazwę: " + nazwaProduktu);
		}


		#endregion

		#region Fields and properties
		private int produktId;

		public int ProduktId
		{
			get { return produktId; }
			set { produktId = value; }
		}

		private string nazwaProduktu;

		public string NazwaProduktu
		{
			get { return nazwaProduktu; }
			set { nazwaProduktu = value; }
		}

		private string opis;

		public string Opis
		{
			get { return opis; }
			set { opis = value; }
		}

		private Dostawca dostawcaProduktu;

		public Dostawca DostawcaProduktu
		{
			get
			{
				if (dostawcaProduktu == null )
				{
					dostawcaProduktu = new Dostawca();
				}
				return dostawcaProduktu;
			}
			set { dostawcaProduktu = value; }
		}

		private DateTime? dataDostepnosci;

		public DateTime? DataDostepnosci
		{
			get { return dataDostepnosci; }
			set { dataDostepnosci = value; }
		}



		#endregion

		public string PowiedzWitaj()
		{
			//var dostawca = new Dostawca();
			//dostawca.WyslijEmailWitamy("Wiadomosc z produktu");

			var emailServices = new EmailService();
			var potwierdzenie = emailServices.WyslijWiadomosc("Nowy produkt",this.NazwaProduktu,"marketing@dev-hobby.pl");

			var wynik = LogowanieService.Logowanie("Powiedziano witaj");

			return "Witaj " + NazwaProduktu + " {" + ProduktId + "}: " + Opis + " Dostepny od : " + DataDostepnosci?.ToShortDateString();
		}
	}
}
