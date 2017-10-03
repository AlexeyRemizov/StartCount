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

            getRange.myFirstElement += getRange.ShowMyFirstElement;
            //Подписка на событие "Сообщение после первого элемента"

            getRange.mySumOfAllElements += getRange.ShowMySumOfAllElements;
            //Подписка на событие "Вывод суммы всех элементов"

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

    public class GetRange
    {
        public delegate void FirstElement();
        public delegate void SumOfAllElements(int sumOfAllElements);
        //Объявление делегатов 

        public event FirstElement myFirstElement;
        //Объявление события для делегата FirstElement()

        public event SumOfAllElements mySumOfAllElements;
        //Объявление события для делегата SumOfAllElements(int sumOfAllElements)


        public IEnumerable<int> StartCount(int start, int count)
        //Аналог метода Range(int,int)
        {
            var sum = 0;
            for (int i = start; i < (count + start); i++)
            {
                sum += i;
                yield return i;
                if (i == start)
                {
                    myFirstElement();
                    //Событие, которое выводит сообщение после первого вызванного элемента
                }
                //mySumOfAllElements(sum); 
                //Использовать в случае, если мы хотим видеть сумму элементов после каждой итерации
            }
            if (sum > 0)
            {
                mySumOfAllElements(sum);
                //Событие, которое принимает сумму всех элементов 
            }
        }

        public void ShowMyFirstElement()
        {
            //Метод, который вызываетcя с помощью delegate FirstElement()
            //Выводит сообщение после первого найденного числа в StartCount(int start, int count)
            Console.WriteLine("EVENT - First element there");
        }

        public void ShowMySumOfAllElements(int mySumOfAllElements)
        {
            //Метод, который вызывается с помощью delegate SumOfAllElements()
            //Выводит сумму всех элементов StartCount(int start, int count), что выведутся
            var sum = mySumOfAllElements;
            Console.WriteLine("EVENT - The sum of elements there are {0}", sum);
        }

    }
}
