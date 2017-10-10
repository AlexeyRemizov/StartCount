using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCount
{
    public class GetRange
    {    
        //Announcement of events
        public event EventHandler <FirstEventArgs> MyFirstElement;
        public event EventHandler<SumOfAllElementsEventArgs> MySumOfAllElements;

        public IEnumerable<int> StartCount(int start, int count)
        {
            EventHandler <FirstEventArgs> hendler = MyFirstElement;
            EventHandler<SumOfAllElementsEventArgs> hendlerSum = MySumOfAllElements;
            var sum = 0;
            for (int i = start; i < (count + start); i++)
            {
                sum += i;
                yield return i;
                if (i == start)
                {
                    if (MyFirstElement != null)
                    {
                        //An event that prints a message after the first element called
                        hendler(this, new FirstEventArgs() { });
                    }
                }
            }
            if (MySumOfAllElements != null)
            {
                hendlerSum(this, new SumOfAllElementsEventArgs() {SumOfAllElements = sum});
                
            }
        }

        //The method that is called by delegate FirstElement ()
        //Prints the message after the first found number in StartCount (int start, int count)
       
    }
}
