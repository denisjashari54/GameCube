using System;
using System.Collections.Generic;

class Hangman
{
    private List<string> wortliste = new List<string>
    {
        "Apfel", "Banane", "Computer", "Programmierung", "Hangman",
        "Schule", "Lastwagen", "Konsole", "Schiff", "Autonomie", "Brasilien"
    };
    private string aktuellesWort;
    private char[] errateneBuchstaben;
    private HashSet<char> falschGerateneBuchstaben;
    private HashSet<char> alleGerateneBuchstaben;
    private int verbleibendeVersuche;

    public Hangman()
    {
        falschGerateneBuchstaben = new HashSet<char>();
        alleGerateneBuchstaben = new HashSet<char>();
        InitialisiereNeuesSpiel();
    }

    private void InitialisiereNeuesSpiel()
    {
        ZufaelligesWortAuswaehlen();
        errateneBuchstaben = new char[aktuellesWort.Length];
        for (int i = 0; i < aktuellesWort.Length; i++)
        {
            errateneBuchstaben[i] = '_';
        }
        verbleibendeVersuche = 7;
        falschGerateneBuchstaben.Clear();
        alleGerateneBuchstaben.Clear();
    }

    private void ZufaelligesWortAuswaehlen()
    {
        Random rand = new Random();
        aktuellesWort = wortliste[rand.Next(wortliste.Count)].ToUpper();
    }

    public void SpielStarten()
    {
        bool weiterSpielen = true;

        while (weiterSpielen)
        {
            Console.Clear();
            InitialisiereNeuesSpiel();
            while (!IstBeendet())
            {
                ZeigeStatus();
                RateVersuch();
            }

            if (Verloren())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Sie haben verloren! Das Wort war {aktuellesWort}.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Glückwunsch! Sie haben gewonnen! Das Wort war: {aktuellesWort}");
            }
            Console.ResetColor();

            weiterSpielen = SpieleNeustartAnfrage();
        }

        Console.WriteLine("Danke fürs Spielen! Drücken Sie eine beliebige Taste, um fortzufahren...");
        Console.ReadKey();
        Console.Clear();
    }

    private bool SpieleNeustartAnfrage()
    {
        while (true)
        {
            Console.WriteLine("Möchten Sie erneut spielen? (j/n): ");
            string antwort = Console.ReadLine().Trim().ToLower();

            if (antwort.Equals("j"))
            {
                Console.Clear();
                return true;
            }
            else if (antwort.Equals("n"))
            {
                Console.Clear();
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie 'j' für Ja oder 'n' für Nein ein.");
                Console.ResetColor();
            }
        }
    }

    private void ZeigeStatus()
    {
        Console.WriteLine(string.Join(" ", errateneBuchstaben)); // Zeige das geratene Wort inklusive Unterstriche
        Console.WriteLine($"Verbleibende Versuche: {verbleibendeVersuche}");
        Console.WriteLine("");
        Console.WriteLine("Bereits geratene Buchstaben: " + string.Join(", ", alleGerateneBuchstaben));

        if (Gewonnen())
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Glückwunsch! Sie haben gewonnen! Das Wort war {aktuellesWort}.");
            Console.ResetColor();
            return; // Beenden Sie die Methode hier, um den restlichen Code nicht auszuführen
        }
    }

    private void RateVersuch()
    {
        Console.WriteLine("Bitte geben Sie einen Buchstaben ein:");
        try
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.Length != 1 || !char.IsLetter(input[0]))
            {
                Console.WriteLine("Bitte geben Sie nur Buchstaben ein. Keine Zahlen oder andere Zeichen.");
                return;
            }

            char geratenerBuchstabe = Char.ToUpper(input[0]);

            if (alleGerateneBuchstaben.Contains(geratenerBuchstabe))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sie haben diesen Buchstaben bereits geraten. Versuchen Sie es mit einem anderen Buchstaben.");
                Console.ResetColor();
            }
            else
            {
                alleGerateneBuchstaben.Add(geratenerBuchstabe);
                VerarbeiteGeratenenBuchstaben(geratenerBuchstabe);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
        }
        finally
        {
            if (!IstBeendet())
            {
                Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    private void VerarbeiteGeratenenBuchstaben(char buchstabe)
    {
        bool treffer = false;

        for (int i = 0; i < aktuellesWort.Length; i++)
        {
            if (aktuellesWort[i] == buchstabe)
            {
                errateneBuchstaben[i] = buchstabe;
                treffer = true;
            }
        }

        if (!treffer)
        {
            verbleibendeVersuche--;
        }
    }

    private bool IstBeendet()
    {
        return Verloren() || Gewonnen();
    }

    private bool Verloren()
    {
        return verbleibendeVersuche <= 0;
    }

    private bool Gewonnen()
    {
        return Array.IndexOf(errateneBuchstaben, '_') == -1;
    }
}
