using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        Namn p = new Namn();
        Console.WriteLine("Förnamn?");
        p.Förnamn = Console.ReadLine();
        Console.WriteLine("Efternamn?");
        p.Efternamn = Console.ReadLine();
        p.FullNamn();
        Console.WriteLine(p.Ålder());
        Console.WriteLine("Höjd?");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Vikt");
        p.Höjd = h;
        double v = double.Parse(Console.ReadLine());
        p.Vikt = v;
        Console.WriteLine(p.BMI(h,v));
    }
}
