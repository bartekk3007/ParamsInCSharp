using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Add(1, 2, 3, 4);
            Console.WriteLine(sum);

            Concatenate("C#", ".NET", "Core", "Framework", "Mono");
            PrintAll(2, 3, 5, 5.7, "exceptions", "structs", "interfaces", "inheritance");
        }
        static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach(int i in numbers)
            {
                sum += i;
            }
            return sum;
        }
        static void Concatenate(params string[] texts)
        {
            foreach(string text in texts)
            {
                Console.Write(text);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        static void PrintAll(params object[] objects)
        {
            foreach (object obj in objects)
            {
                Console.Write(obj.ToString());
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
