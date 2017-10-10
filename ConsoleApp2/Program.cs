using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summ = 0;
            var result = 0;
            GetRange getRange = new GetRange();

            //Subscription to the event "Message after the first item"
            getRange.MyFirstElement += Program.ShowMyFirstElement;

            //Subscription to the event "Displaying the sum of all items"
            getRange.MySumOfAllElements += Program.ShowMySumOfAllElements;

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

        //The method that is called with event MyFirstElement()
        public static void ShowMyFirstElement(object sender, FirstEventArgs e)
        {
            Console.WriteLine("EVENT - First element there");
        }

        //The method that is called with event MySumOfAllElements()
        //Outputs the sum of all the StartCount (int start, int count) items that are output
        public static void ShowMySumOfAllElements(object sender, SumOfAllElementsEventArgs e)
        {   
            Console.WriteLine("EVENT - The sum of elements there are {0}", e.SumOfAllElements);
        }

    }

}
