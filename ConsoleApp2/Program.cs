using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Example exampleOfStartCountMethod = new Example();
            exampleOfStartCountMethod.myFirstElement += exampleOfStartCountMethod.ShowMessage1;
            exampleOfStartCountMethod.AmountOfElements += exampleOfStartCountMethod.ShowMessage2;
            exampleOfStartCountMethod.PrintResults();



            Console.ReadKey();
        }

        

        

        
    }

    public class GetRange
    {
        public IEnumerable<int> StartCount(int start, int count)
        {
            for (int i = start; i < (count + start); i++)
                yield return i;
        }
    }

    public class Example
    {

        public delegate void GetMessage();
        public event GetMessage myFirstElement;
        public event GetMessage AmountOfElements;

        

        public void PrintResults()
        {

            var summ = 0;
            var result = 0;
            GetRange getRange = new GetRange();
            foreach (int item in getRange.StartCount(3, 8))
            {
                Console.WriteLine();
                result++;
                
                Console.WriteLine("Element #{0} is {1}.", result, item);
                summ += item;
                if (result == 1)
                {
                   myFirstElement();
                }
            }
            AmountOfElements();
            Console.WriteLine("The total number of elements is {0}, the sum of elements is {1}", result, summ);
            Console.WriteLine();
        }

        

        public void ShowMessage1()
        {
            
            Console.WriteLine("First element there");
        }

        public void ShowMessage2()
        {
            Console.WriteLine("The sum of elements is there");
        }
    }


}
