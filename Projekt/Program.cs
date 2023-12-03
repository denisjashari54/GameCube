class Programm
{
    static void Main(string[] args)
    {
        bool spielLaeuft = true;
        Console.WriteLine("###########################################################################");
        Console.WriteLine("  ________                        _________      ___.           ");
        Console.WriteLine(" /  _____/_____    _____   ____   \\_   ___ \\ __ _\\_ |__   ____  ");
        Console.WriteLine("/   \\  ___\\__  \\  /     \\_/ __ \\  /    \\  \\/|  |  \\ __ \\_/ __ \\ ");
        Console.WriteLine("\\    \\_\\  \\/ __ \\|  Y Y  \\  ___/  \\     \\___|  |  / \\_\\ \\  ___/ ");
        Console.WriteLine(" \\______  (____  /__|_|  /\\___  >  \\______  /____/|___  /\\___  >");
        Console.WriteLine("        \\/     \\/      \\/     \\/          \\/          \\/     \\/ ");
        Console.WriteLine("");
        Console.WriteLine("###########################################################################");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Willkommen zu GameCube! Wählen Sie ein Spiel:");
        Console.ResetColor();
        Console.WriteLine("");
        Console.WriteLine("1: Tic-Tac-Toe\n2: Hangman\n3: Spiel beenden");

        while (spielLaeuft)
        {
            Console.WriteLine("");
            Console.Write("Bitte treffen Sie Ihre Auswahl (1, 2, oder 3): ");
            string auswahl = Console.ReadLine();

            switch (auswahl)
            {
                case "1":
                    Spiel ticTacToeSpiel = new Spiel();
                    ticTacToeSpiel.StarteSpiel();
                    Console.WriteLine("###########################################################################");
                    Console.WriteLine("  ________                        _________      ___.           ");
                    Console.WriteLine(" /  _____/_____    _____   ____   \\_   ___ \\ __ _\\_ |__   ____  ");
                    Console.WriteLine("/   \\  ___\\__  \\  /     \\_/ __ \\  /    \\  \\/|  |  \\ __ \\_/ __ \\ ");
                    Console.WriteLine("\\    \\_\\  \\/ __ \\|  Y Y  \\  ___/  \\     \\___|  |  / \\_\\ \\  ___/ ");
                    Console.WriteLine(" \\______  (____  /__|_|  /\\___  >  \\______  /____/|___  /\\___  >");
                    Console.WriteLine("        \\/     \\/      \\/     \\/          \\/          \\/     \\/ ");
                    Console.WriteLine("");
                    Console.WriteLine("###########################################################################");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Willkommen zu GameCube! Wählen Sie ein Spiel:");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("1: Tic-Tac-Toe\n2: Hangman\n3: Spiel beenden");
                    break;
                case "2":
                    Hangman hangmanSpiel = new Hangman();
                    hangmanSpiel.SpielStarten();
                    Console.WriteLine("###########################################################################");
                    Console.WriteLine("  ________                        _________      ___.           ");
                    Console.WriteLine(" /  _____/_____    _____   ____   \\_   ___ \\ __ _\\_ |__   ____  ");
                    Console.WriteLine("/   \\  ___\\__  \\  /     \\_/ __ \\  /    \\  \\/|  |  \\ __ \\_/ __ \\ ");
                    Console.WriteLine("\\    \\_\\  \\/ __ \\|  Y Y  \\  ___/  \\     \\___|  |  / \\_\\ \\  ___/ ");
                    Console.WriteLine(" \\______  (____  /__|_|  /\\___  >  \\______  /____/|___  /\\___  >");
                    Console.WriteLine("        \\/     \\/      \\/     \\/          \\/          \\/     \\/ ");
                    Console.WriteLine("");
                    Console.WriteLine("###########################################################################");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Willkommen zu GameCube! Wählen Sie ein Spiel:");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.WriteLine("1: Tic-Tac-Toe\n2: Hangman\n3: Spiel beenden");
                    break;
                case "3":
                    spielLaeuft = false;
                    Console.WriteLine("Das Spiel wird beendet.");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie 1, 2 oder 3.");
                    Console.ResetColor();
                    break;
            }
        }
    }
}

