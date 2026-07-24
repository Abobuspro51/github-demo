

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
            Console.WriteLine("========================================");
            Console.WriteLine("         Casino od polskiej krowy      ");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine("zustatek:" + balance);
            Console.WriteLine();
            Console.WriteLine("1-hrat");
            Console.WriteLine("2-statystyky");
            Console.WriteLine("3-konec");
            Console.WriteLine();

            Console.WriteLine("vyberte možnost: ");
            string menu = Console.ReadLine();

            if (menu == "Vladislav 1307" )
            {
                Console.WriteLine("Taty mate penize");
                balance *= 100000;
                continue;
            }

            if (menu == "228")
            {
                Console.WriteLine("Taty mate penize");
                balance += 10000;
                continue;
            }






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

            int sazka;

            if (!int.TryParse(Console.ReadLine(), out sazka))
            {
                Console.WriteLine("Musiš zadat čislo");
                Console.ReadLine();
                continue;
            }

            if (sazka <= 0) 
            {
                Console.WriteLine("sazka musi byt vic než 0!)");
                Console.ReadLine();
                continue;
            }
            if (sazka > balance)
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

                Console.WriteLine("         -----------");
                Console.WriteLine($"         |{w}   {x}   {e}|    ");
                Thread.Sleep(500);
                Console.WriteLine($"         |{r}   {w}   {p}|    ");
                Thread.Sleep(500);
                Console.WriteLine($"         |{p}   {r}   {q}|    ");
                Thread.Sleep(500);
                Console.WriteLine($"         |{u}   {w}   {p}|    ");
                Thread.Sleep(500);
                Console.WriteLine($"         |{w}   {q}   {o}|    ");
                Thread.Sleep(500);
                Console.WriteLine($"         |{r}   {q}   {o}|    ");
                Thread.Sleep(500);
                Console.WriteLine($"         |{e}   {t}   {o}|    ");
                Thread.Sleep(500);
                Console.WriteLine($"         |{p}   {e}   {i}|    ");
                Thread.Sleep(800);
                Console.WriteLine($"         |{o}   {w}   {u}|    ");
                Thread.Sleep(1000);
                Console.WriteLine($"         |{r}   {p}   {q}|    ");
                Thread.Sleep(1200);
                Console.WriteLine($"         |{p}   {t}   {o}|    ");
                break;
            }
            

            
                Thread.Sleep(1500);
            

            int a = random.Next(1, 8);
            int b = random.Next(1, 8);
            int c = random.Next(1, 8);

            


            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Vysledek: {a} | {b} | {c}");
            Console.WriteLine("-----------------------------");

            games++;
            if (a == b && b == c)
            {
                int prize = sazka * 10;
                balance += prize;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("jakpod!");
                Console.WriteLine("Vyhral jsi " + prize + "kč");
                Console.ResetColor();

                wins++;
            }
            else if (a == b || a == c || b == c)
            {
                int prize = sazka * 2;
                balance += prize;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("dvě stejna čisla!");
                Console.WriteLine("Vyhral jsi " + prize + "kč");
                Console.ResetColor();

                wins++;
            }
            else
            {
                balance -= sazka;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("prohral jsi " + sazka + "Kč");
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
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("stiskni Enter pro pokračovani");
            Console.ReadLine();
        }
    }
}
