﻿using DevHobby.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevHobby.BLL
{
	/// <summary>
	/// Zarzadza dostawcami od ktorych kupujemy nasze produkty
	/// </summary>

    public class Dostawca
    {
		public int DostawcaId { get; set; }
		public string NazwaFirmy { get; set; }
		public string Email { get; set; }


		/// <summary>
		/// Wysyla wiadomosc email, aby powitac nowego dostawce
		/// </summary>
		/// <param name="wiadomosc"></param>
		/// <returns></returns>
		public string WyslijEmailWitamy(string wiadomosc)
		{
			var emailService = new EmailService();
			var temat = ("Witaj " + this.NazwaFirmy).Trim();
			var potwierdzenie = emailService.WyslijWiadomosc(temat, wiadomosc, this.Email);

			return potwierdzenie;
		}

	}
}
