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
            var summ = 0;
            var result = 0;
            GetRange getRange = new GetRange();

            //Subscription to the event "Message after the first item"
            getRange.myFirstElement += getRange.ShowMyFirstElement;

            //Subscription to the event "Displaying the sum of all items"
            getRange.mySumOfAllElements += getRange.ShowMySumOfAllElements;

            foreach (int item in getRange.StartCount(3, 8))
            {
                Console.WriteLine();
                result++;

                Console.WriteLine("Element #{0} is {1}.", result, item);
                summ += item;
            }
            Console.WriteLine("The total number of elements is {0}, the sum of elements is {1}", result, summ);
            Console.WriteLine();
            Console.ReadKey();
        }
   
    }

}
