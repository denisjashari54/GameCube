using System;

class Spiel
{
    private Spielbrett brett;
    private Spieler[] spieler = new Spieler[2];
    private int aktuellerSpielerIndex = 0;

    public Spiel()
    {
        brett = new Spielbrett();
        spieler[0] = new Spieler("Spieler 1", 'X');
        spieler[1] = new Spieler("Spieler 2", 'O');
    }

    public void StarteSpiel()
    {
        bool spielLaeuft = true;

        while (spielLaeuft)
        {
            brett.ResetBrett();
            int runde = 0;
            bool spielBeendet = false;

            while (!spielBeendet && runde < 9)
            {
                Console.Clear();
                brett.ZeigeBrett();
                bool zugErfolgreich = false;

                while (!zugErfolgreich)
                {
                    Console.WriteLine($"{spieler[aktuellerSpielerIndex].Name} ({spieler[aktuellerSpielerIndex].Symbol}), es ist Ihr Zug. Bitte wählen Sie ein Feld (1-9):");
                    string eingabe = Console.ReadLine();
                    int feldNummer;
                    if (int.TryParse(eingabe, out feldNummer))
                    {
                        if (brett.MacheZug(feldNummer, spieler[aktuellerSpielerIndex].Symbol))
                        {
                            zugErfolgreich = true;
                            if (brett.IstSiegbedingungErreicht())
                            {
                                Console.Clear();
                                brett.ZeigeBrett();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{spieler[aktuellerSpielerIndex].Name} hat gewonnen!");
                                Console.ResetColor();
                                spielBeendet = true;
                            }
                            else if (runde == 8)
                            {
                                Console.Clear();
                                brett.ZeigeBrett();
                                Console.WriteLine("Unentschieden!");
                                spielBeendet = true;
                            }
                            runde++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ungültiger Zug, das Feld ist bereits belegt oder existiert nicht.");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 9 ein.");
                        Console.ResetColor();
                    }
                }

                aktuellerSpielerIndex = (aktuellerSpielerIndex + 1) % 2;
            }

            Console.Write("Möchten Sie erneut spielen? (j/n): ");
            string antwort = Console.ReadLine().ToLower();

            while (antwort != "j" && antwort != "n")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie 'j' oder 'n' ein.");
                Console.ResetColor();
                Console.Write("Möchten Sie erneut spielen? (j/n): ");
                antwort = Console.ReadLine().ToLower();
            }

            if (antwort == "n")
            {
                spielLaeuft = false;
            }

            Console.Clear();
        }
    }
}
