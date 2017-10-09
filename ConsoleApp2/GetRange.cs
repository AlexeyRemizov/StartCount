using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class GetRange
    {

        //Announcement of delegates
        public delegate void FirstElement();
        public delegate void SumOfAllElements(int sumOfAllElements);

        public event EventHandler <FirstSumEventArgs> MyFirstElement;

        //Declaring an event for the FirstElement delegate ()
        public event FirstElement myFirstElement;

        //Announcing an event for the SumOfAllElements delegate (int sumOfAllElements)
        public event SumOfAllElements mySumOfAllElements;

        //An analog of the Range method (int, int)
        public IEnumerable<int> StartCount(int start, int count)
        {
            EventHandler<FirstSumEventArgs> handler = MyFirstElement;          
            var sum = 0;
            for (int i = start; i < (count + start); i++)
            {
                sum += i;
                yield return i;
                if (i == start)
                {

                    //An event that prints a message after the first element called
                    myFirstElement();
                    
                }
                //Use in case we want to see the sum of the elements after each iteration
                //mySumOfAllElements(sum); 

            }
            if (sum > 0)
            {
                //An event that takes the sum of all the elements
                mySumOfAllElements(sum);
            }
        }

        //The method that is called by delegate FirstElement ()
        //Prints the message after the first found number in StartCount (int start, int count)
        public void ShowMyFirstElement()
        {
            
            Console.WriteLine("EVENT - First element there");
        }

        //The method that is called with delegate SumOfAllElements ()
        //Outputs the sum of all the StartCount (int start, int count) items that are output
        public void ShowMySumOfAllElements(int mySumOfAllElements)
        {
            
            var sum = mySumOfAllElements;
            Console.WriteLine("EVENT - The sum of elements there are {0}", sum);
        }
    }
}
