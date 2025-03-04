using System;

namespace dane
{ 
public class pracownik
{
	public pracownik()
	{
		public int ID { get; set; }
		public string FirstName {  get; set; }
		public string LastName { get; set; }
		public decimal Zarobki { get; set; }
		public DateTime Zatrudnienie { get; set; }
		public DateTime? Zwolnienie {  set; get; }

	public user(string FirstName, string LastName, decimal Zarobki)
	{
		Id = ID;
		FirstName = FirstName;
		LastName = LastName;
		Zarobki = Zarobki;
		Zatrudnienie= Zatrudnienie.Now;
		Zwolnienie = null

		
	}
	}
}
}