using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektiv2
{
	class Program
	{
		static void Main(string[] args)
		{
			int broj;
			string nekiTekst;

			List<Osoba> lista = new List<Osoba>();

			Osoba nekaOsoba = new Osoba("Pera", "Peric", "Negde nesto BB", "06512345678");
			lista.Add(nekaOsoba);

			nekaOsoba = new Osoba("Neko", "Nekic", "Negde drugde BB", "0659876543241");
			lista.Add(nekaOsoba);

			nekaOsoba = new Osoba("Trecko", "Treckovic", "12345");
			lista.Add(nekaOsoba);

			foreach (Osoba o in lista)
			{
				Console.WriteLine($"{o.Ime} {o.Prezime} {o.BrojTelefona} {o.Adresa}");
				Console.WriteLine("----------------------------------");
			}


			Console.ReadKey();

		}
	}

	class Osoba
	{
		public Osoba(string i, string p, string a, string b)
		{
			Ime = i;
			Prezime = p;
			Adresa = a;
			BrojTelefona = b;
		}

		public Osoba(string i, string p, string b)
		{
			Ime = i;
			Prezime = p;
			BrojTelefona = b;
		}


		public string Ime;
		public string Prezime;
		public string Adresa;
		public string BrojTelefona;
	}
}
