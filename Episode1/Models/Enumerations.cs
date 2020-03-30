using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Episode1.Models
{
    public class Enumerations
    {
        public void Test()
        {
            var numbersList = Enumerable.Range(1, 100).ToList();
            IEnumerable<int> numbers = GetNumbers();
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            var enumerator = numbers.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        public IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
        }
    }
}
