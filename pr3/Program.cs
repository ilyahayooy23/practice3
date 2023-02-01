using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Пианино.Октавы");
        while (true)
        {
            Console.WriteLine("F1 - Первая октава");
            Console.WriteLine("F2 - Вторая октава");
            Console.WriteLine("Нажмите для выбора:");

            ConsoleKeyInfo x = Console.ReadKey();
            if (x.Key == ConsoleKey.F1)
            {
                int[] first = new int[12] { 3270, 3460, 3670, 3880, 4120, 4360, 4620, 4900, 5190, 5500, 5820, 6170 };
                Octave(first);
            }
            if (x.Key == ConsoleKey.F2)
            {
                int[] second = new int[12] { 6540, 6930, 7340, 7770, 8240, 8730, 9250, 9800, 10300, 11000, 11600, 12300 };
                Octave(second);
            }
        }
    }

    static void Octave(int[] notes)
    {
        ConsoleKeyInfo i = Console.ReadKey();
        while (i.Key != ConsoleKey.Escape)
        {
            if (i.Key == ConsoleKey.A)
            {
                Console.Beep(notes[0], 400);
            }
            if (i.Key == ConsoleKey.B)
            {
                Console.Beep(notes[1], 400);
            }
            if (i.Key == ConsoleKey.C)
            {
                Console.Beep(notes[2], 400);
            }
            if (i.Key == ConsoleKey.D)
            {
                Console.Beep(notes[3], 400);
            }
            if (i.Key == ConsoleKey.E)
            {
                Console.Beep(notes[4], 400);
            }
            if (i.Key == ConsoleKey.F)
            {
                Console.Beep(notes[5], 400);
            }
            if (i.Key == ConsoleKey.G)
            {
                Console.Beep(notes[6], 400);
            }
            if (i.Key == ConsoleKey.H)
            {
                Console.Beep(notes[7], 400);
            }
            if (i.Key == ConsoleKey.I)
            {
                Console.Beep(notes[8], 400);
            }
            if (i.Key == ConsoleKey.J)
            {
                Console.Beep(notes[9], 400);
            }
            if (i.Key == ConsoleKey.K)
            {
                Console.Beep(notes[10], 400);
            }
            if (i.Key == ConsoleKey.L)
            {
                Console.Beep(notes[11], 400);
            }
            i = Console.ReadKey();
        }
    }
}
