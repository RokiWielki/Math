//Dwaj koledzy Janek i Karol zadłużyli się na 80 zł. Umówili się między sobą, że każdy z
//nich codziennie będzie odkładał na spłatę zadłużenia 20% swojego dziennego zarobku, Janek
//zarabia dziennie 50 zł, a Karol 40 zł. Napisz program, który przy pomocy pętli do..while
//sprawdzi po ilu dniach obaj koledzy uzbierają kwotę potrzebną do spłaty swojego długu oraz
//wypisze wartość uzbieranej kwoty w każdym dniu.

using System;

namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int debt = 80;
            int earnJ = 50;
            int earnK = 40;
            Console.WriteLine("Janek: ");
            Savings(debt,earnJ);
            Console.WriteLine("Karol: ");
            Savings(debt,earnK);
            Console.WriteLine("Second Janek: ");
            Savingss(debt, earnJ);
            Console.WriteLine("Second Karol: ");
            Savingss(debt, earnK);
        }
        static void Savings(int debt, int earn)
        {
            int days=1;
            int refound;
            earn = earn / 5;
            Console.WriteLine("Initial debt :"+debt);
            do
            {
                refound = debt - earn;
                debt-=earn;
                Console.WriteLine("Day "+ days+". " + refound);
                days++;
            } while (refound != 0);
            Console.WriteLine("");
        }
        static void Savingss(int debt,int earn)
        {
            int days = 1;
            int refound = 0;
            earn /= 5;
            Console.WriteLine("Initial debt :" + debt);
            do
            {
                refound += earn;
                Console.WriteLine("Day " + days + ". " + refound);
                days++;
            } while(refound <debt);
            Console.WriteLine("");
        }
    }
}
