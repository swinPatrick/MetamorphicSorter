using System;
using System.Collections.Generic;

namespace Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiate Sorters with respectful characteristics
            SorterProper P = new SorterProper(SorterProper.Type.Working);
            SorterProper M1 = new SorterProper(SorterProper.Type.Mutant1);
            SorterProper M2 = new SorterProper(SorterProper.Type.Mutant2);


            //Generate Results based on MRs and write to console
            MRCalculator c = new MRCalculator();
            Console.WriteLine("=========\nWorking Program: ");
            Console.WriteLine(c.CalculateMRResults(P));
            Console.WriteLine("=========\nMutant Program 1: ");
            Console.WriteLine(c.CalculateMRResults(M1));
            Console.WriteLine("=========\nMutant Program 2: ");
            Console.WriteLine(c.CalculateMRResults(M2));
        }
    }
}