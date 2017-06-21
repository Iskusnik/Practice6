using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    class Program
    {
        /// <summary>
        /// 14.	
        /// Ввести а1, а2, а3, N. 
        /// Построить последовательность чисел а[к] = ( а[к–1] + а[к-2] ) / 2 –  а[к–3]. 
        /// Построить N элементов последовательности. 
        /// Определить длину максимальной возрастающей подпоследовательности. 
        /// Напечатать последовательность, длину и последний элемент максимальной возрастающей подпоследовательности. 
        /// </summary>
        /// 
        static void Main(string[] args)
        {
            int a1, a2, a3, N;
            Console.WriteLine("а[к] = (а[к–1] + а[к-2]) / 2 – а[к–3]");

            Console.WriteLine("a1 =");
            a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("a2 =");
            a2 = int.Parse(Console.ReadLine());

            Console.WriteLine("a3 =");
            a3 = int.Parse(Console.ReadLine());

            Console.WriteLine("N =");
            N = int.Parse(Console.ReadLine());
        }
    }
}
