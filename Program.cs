using System;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");


            //Kutsume WhereLINQ meetodi välja 
            SequenceEqual();
            SumLINQ();
        }
        public static void SequenceEqual()
        {
            Console.WriteLine("SequenceEqual LINQ");
            IList<string> stringsList1 = new List<string>()
            { "One", "Two", "Three", "Four", "Five"};
            IList<string> stringsList2 = new List<string>()
            { "One", "Two", "Three", "Four"};
            //see kontrollib, kas seal on väärtuseid või ei ole
            //kas seal on üks ühele olemas väärtused
            bool isEqual = stringsList1.SequenceEqual(stringsList2);
            Console.WriteLine(isEqual);
        }
        public static void SumLINQ()
        {
            Console.WriteLine("Sum LINQ");
            var total = SumLINQ;
            Console.WriteLine("Sum of even elements: " + total);
        }
    }
}