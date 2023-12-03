using System;

class Spielbrett
{
    private char[,] brett = new char[3, 3];

    public Spielbrett()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                brett[i, j] = (char)('1' + i * 3 + j);
            }
        }
    }

    public void ZeigeBrett()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", brett[0, 0], brett[0, 1], brett[0, 2]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", brett[1, 0], brett[1, 1], brett[1, 2]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", brett[2, 0], brett[2, 1], brett[2, 2]);
        Console.WriteLine("     |     |      ");
    }

    public bool MacheZug(int nummer, char spieler)
    {
        int reihe = (nummer - 1) / 3;
        int spalte = (nummer - 1) % 3;

        if (nummer < 1 || nummer > 9 || brett[reihe, spalte] == 'X' || brett[reihe, spalte] == 'O')
        {
            return false;
        }

        brett[reihe, spalte] = spieler;
        return true;
    }

    public bool IstSiegbedingungErreicht()
    {
        for (int i = 0; i < 3; i++)
        {
            if (brett[i, 0] == brett[i, 1] && brett[i, 1] == brett[i, 2])
                return true;
        }

        for (int j = 0; j < 3; j++)
        {
            if (brett[0, j] == brett[1, j] && brett[1, j] == brett[2, j])
                return true;
        }

        if (brett[0, 0] == brett[1, 1] && brett[1, 1] == brett[2, 2])
            return true;
        if (brett[0, 2] == brett[1, 1] && brett[1, 1] == brett[2, 0])
            return true;

        return false;
    }
    public void ResetBrett()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                brett[i, j] = (char)('1' + i * 3 + j);
            }
        }
    }
}

