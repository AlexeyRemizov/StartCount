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
        public event EventHandler<FirstEventArgs> FirstElementEA;
        public event EventHandler<SumOfAllElementsEventArgs> SumOfAllElementsEA;
        public IEnumerable<int> StartCount(int start, int count)
        {
            var sum = 0;
            for (int i = start; i < (count + start); i++)
            {
                sum += i;
                yield return i;
                if (i == start)
                {
                    if (FirstElementEA != null)
                    {
                        //An event that prints a message after the first element called
                        FirstElementEA(this, new FirstEventArgs() { });
                    }
                }
            }
            if (SumOfAllElementsEA != null)
            {
                SumOfAllElementsEA(this, new SumOfAllElementsEventArgs() {SumOfAllElements = sum});
                
            }
        }
       
    }
}
