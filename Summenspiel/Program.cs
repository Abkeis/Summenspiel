using System;

// Anlegen neuer Klasse mit Namen "Program" 
public class Program
{

	// Main ist die Hauptmethode
	public static void Main()
	{
		// Array mit der Größe 6 - Habe 6 Variablen erzeugt 
		int[] x = new int[6];
		String eingabe = "";
		int summe = 0;

		/// Ausgabe der Benutzerführung
		Console.WriteLine("Geben Sie bitte 6 Zahlen ein!");

		for (int i = 0; i < 6; i++)
		{
			Console.WriteLine("Bitte geben Sie die Zahl Nr.:" + (i + 1) + " ein:");
			eingabe = Console.ReadLine();

			/// Variante 2 mit Parse
			x[i] = Int32.Parse(eingabe);
			summe += x[i];
		}

		if (summe >= 100)
		{
			Console.WriteLine("Gewonnen");
		}
		else
		{
			Console.WriteLine("Verloren");
		}


	}
}