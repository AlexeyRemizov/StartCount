﻿using System;
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

        public event EventHandler <FirstEventArgs> MyFirstElement;

        //Declaring an event for the FirstElement delegate ()
        public event FirstElement myFirstElement;

        //Announcing an event for the SumOfAllElements delegate (int sumOfAllElements)
        public event SumOfAllElements mySumOfAllElements;

        //An analog of the Range method (int, int)
        public IEnumerable<int> StartCount(int start, int count)
        {
            EventHandler <FirstEventArgs> hendler = MyFirstElement;        
            var sum = 0;
            for (int i = start; i < (count + start); i++)
            {
                sum += i;
                yield return i;
                if (i == start)
                {

                    //An event that prints a message after the first element called
                    //myFirstElement();
                    hendler(this, new FirstEventArgs() { });
                    
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
       
    }
}
