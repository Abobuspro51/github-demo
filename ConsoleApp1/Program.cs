

using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int balance = 1000;
        int games = 0;
        int wins = 0;
        int loses = 0;

        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=============================");
            Console.WriteLine("        100% win Casino      ");
            Console.WriteLine("=============================");
            Console.ResetColor();

            Console.WriteLine("zustatek:" + balance);
            Console.WriteLine();
            Console.WriteLine("1-hrat");
            Console.WriteLine("2-statystyky");
            Console.WriteLine("3-konec");
            Console.WriteLine();

            Console.WriteLine("vyberte možnost: ");
            string menu = Console.ReadLine();

            if (menu == "3") 
            {
                Console.WriteLine("děkujeme za hru");
                break;
            }

            if (menu == "2")
            {
                Console.Clear();
                Console.WriteLine("statystyky");
                Console.WriteLine("-------------------");
                Console.WriteLine("počet her:" + games);
                Console.WriteLine("vyhry: " + wins);
                Console.WriteLine("prohry" + loses);
                Console.WriteLine("zustatek" + balance);
                Console.WriteLine();
                Console.WriteLine("stiskni enter...");
                Console.ReadLine();
                continue;
            }

            if (menu != "1")
            {
                continue;
            }

            Console.Clear();
            Console.WriteLine("zadejte sazku: ");

            int bet;

            if (!int.TryParse(Console.ReadLine(), out bet))
            {
                Console.WriteLine("Musiš zadat čislo");
                Console.ReadLine();
                continue;
            }

            if (bet <= 0) 
            {
                Console.WriteLine("sazka musi byt vic než 0!)");
                Console.ReadLine();
                continue;
            }
            if (bet > balance)
            {
                Console.WriteLine("Nemaš dostatek peněz");
                Console.ReadLine();
                continue;
            }

            Console.WriteLine();
            Console.WriteLine("točim automatem");

            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(1, 10);
                int y = random.Next(1, 10);
                int z = random.Next(1, 10);
                int q = random.Next(1, 10);
                int w = random.Next(1, 10);
                int e = random.Next(1, 10);
                int r = random.Next(1, 10);
                int t = random.Next(1, 10);
                int u = random.Next(1, 10);
                int o = random.Next(1, 10);
                int p = random.Next(1, 10);
                










                Console.Clear();
                Console.WriteLine("točim automat");
                Console.WriteLine();

                Console.WriteLine($"          {x}   {x}   {x}    ");
                Console.WriteLine($"          {y}   {y}   {y}    ");
                Console.WriteLine($"          {z}   {z}   {z}    ");
                Console.WriteLine($"          {q}   {q}   {q}    ");
                Console.WriteLine($"          {w}   {w}   {w}    ");
                Console.WriteLine($"          {e}   {e}   {e}    ");
                Console.WriteLine($"          {r}   {r}   {r}    ");
                Console.WriteLine($"          {t}   {t}   {t}    ");
                Console.WriteLine($"          {u}   {u}   {u}    ");
                Console.WriteLine($"          {o}   {o}   {o}    ");
                Console.WriteLine($"          {p}   {p}   {p}    ");
                



            }
            

            
                Thread.Sleep(1500);
            

            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);

            


            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Vysledek: {a} | {b} | {c}");
            Console.WriteLine("-----------------------------");

            games++;
            if (a == b && b == c)
            {
                int prize = bet * 10;
                balance += prize;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("jakpod!");
                Console.WriteLine("Vyhral jsi " + prize + "kč");
                Console.ResetColor();

                wins++;
            }
            else if (a == b || a == c || b == c)
            {
                int prize = bet * 2;
                balance += prize;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("dvě stejna čisla!");
                Console.WriteLine("Vyhral jsi " + prize + "kč");
                Console.ResetColor();

                wins++;
            }
            else
            {
                balance -= bet;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("prohral jsi " + bet + "Kč");
                Console.ResetColor();

                loses++; 
            }

            if (balance <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Došli ti penize");
                Console.WriteLine("Konec hry");
                break;
            }
            Console.WriteLine();
            Console.WriteLine("stiskni Enter pro pokračovani");
            Console.ReadLine();
        }
    }
}