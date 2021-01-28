using System;
using System.IO;
using System.Text;
using System.Data.SQLite;

namespace WSBProjectCZ1
{
	public class database {
		public void zainicjuj() {
			SQLiteConnection.CreateFile("database.db3");
			
			SQLiteConnection conn = new SQLiteConnection(@"data source = database.db3");
			
			conn.Open();
			SQLiteCommand cmd = new SQLiteCommand("create table pracownicy(pesel integer, imie varchar(32), nazwisko varchar(32), nazwa_uzytkownik varchar(32), password varchar(32), specjalnosc varchar(32), numerPWZ varchar(32)", conn);
			cmd.ExecuteNonQuery();
			SQLiteCommand cmd2 = new SQLiteCommand("create table dyzury(pesel integer, data date)", conn);
			cmd2.ExecuteNonQuery();
			conn.Close();
			}
	}
	public class Pracownik
	{
		protected string imie;
		protected string nazwisko;
		protected string pesel;
		protected string nazwa_uzytkownika;
		protected string haslo;

		public string getImie() {
			return this.imie;
		}
		public string getNazwisko()
		{
			return this.nazwisko;
		}
		public string getPesel()
		{
			return this.pesel;
		}
		public string getNazwa()
		{
			return this.nazwa_uzytkownika;
		}
		public string getHaslo()
		{
			return this.haslo;
		}
	}
	public class Lekarz : Pracownik
	{
		private string specjalnosc;
		private string numerPWZ;
		private string dyzury;
		public Lekarz(string imie, string nazwisko, string pesel, string nazwa_uzytkownika, string haslo, string specjalnosc, string numerPWZ, string dyzury) {
			this.imie = imie;
			this.nazwisko = nazwisko;
			this.pesel = pesel;
			this.nazwa_uzytkownika = nazwa_uzytkownika;
			this.haslo = haslo;
			this.specjalnosc = specjalnosc;
			this.numerPWZ = numerPWZ;
			this.dyzury = dyzury;
		}
		public string getSpecjalnosc() {
			return this.specjalnosc;
		}
		public string getNumerPWZ()
		{
			return this.numerPWZ;
		}
		public string getDyzury()
		{
			return this.dyzury;
		}
	}
	public class Pielegniarka : Pracownik
	{
		string dyzury;
		public Pielegniarka(string imie, string nazwisko, string pesel, string nazwa_uzytkownika, string haslo, string dyzury)
		{
			this.imie = imie;
			this.nazwisko = nazwisko;
			this.pesel = pesel;
			this.nazwa_uzytkownika = nazwa_uzytkownika;
			this.haslo = haslo;
			this.dyzury = dyzury;
		}
		public string getDyzury()
		{
			return this.dyzury;
		}
	}
	public class Admin : Pracownik
	{
		public Admin(string imie, string nazwisko, string pesel, string nazwa_uzytkownika, string haslo)
		{
			this.imie = imie;
			this.nazwisko = nazwisko;
			this.pesel = pesel;
			this.nazwa_uzytkownika = nazwa_uzytkownika;
			this.haslo = haslo;
		}
		public void dodajUzytkownika() {
			Console.WriteLine("Podaj imie");
			string imie = Console.ReadLine();
			Console.WriteLine("Podaj nazwisko");
			string nazwisko = Console.ReadLine();
			Console.WriteLine("Podaj pesel");
			string pesel = Console.ReadLine();
			Console.WriteLine("Podaj nazwa uzytkownika");
			string nazwa_uzytkownika = Console.ReadLine();
			Console.WriteLine("Podaj haslo");
			string haslo = Console.ReadLine();
			Console.WriteLine("Podaj specjalnosc");
			string specjalnosc = Console.ReadLine();
			Console.WriteLine("Podaj numerPWZ");
			string numerPWZ = Console.ReadLine();
			Console.WriteLine("dyzury");
			string dyzury = Console.ReadLine();
			Lekarz nowyLekarz = new Lekarz(imie, nazwisko, pesel, nazwa_uzytkownika, haslo, specjalnosc, numerPWZ, dyzury);
			string sqlCommand = "insert into pracownicy(pesel, imie, nazwisko, nazwa_uzytkownika, password, specjalnosc, numerPWZ) VALUES (" + nowyLekarz.getPesel() + nowyLekarz.getImie() + nowyLekarz.getNazwisko() + nowyLekarz.getNazwa() + nowyLekarz.getHaslo() + nowyLekarz.getSpecjalnosc() + nowyLekarz.getNumerPWZ();
		}
		public void usunUzytkownika() {

		}
		public void edytujUzytkownika() {

		}
		public void dodajDuzyr() { 
		
		}
		public void edytujDyzur() { 
		
		}
		public void usunDyzur() { 
		
		}
	}
}
