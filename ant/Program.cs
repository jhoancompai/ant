using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string ants = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";
        int deadAnts = DeadAntCount(ants);
        Console.WriteLine("Número de hormigas muertas: " + deadAnts);
    }

    public static int DeadAntCount(string antString)
    {
        if (string.IsNullOrEmpty(antString))
        {
            return 0;
        }

        antString = antString.Replace("ant", "");

        int aCount = antString.Count(c => c == 'a');
        int nCount = antString.Count(c => c == 'n');
        int tCount = antString.Count(c => c == 't');

        return Math.Max(Math.Max(aCount, nCount), tCount);
    }
}

