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
            double a1, a2, a3;
            int N;
            Console.WriteLine("а[к] = (а[к–1] + а[к-2]) / 2 – а[к–3]");

            Console.WriteLine("a1 =");
            a1 = double.Parse(Console.ReadLine());

            Console.WriteLine("a2 =");
            a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("a3 =");
            a3 = double.Parse(Console.ReadLine());

            Console.WriteLine("N =");
            N = int.Parse(Console.ReadLine());

            double[] a = new double[N + 3];
            a[0] = a1;
            a[1] = a2;
            a[2] = a3;

            for (int i = 3; i < N + 3; i++)
                a[i] = (a[i - 1] + a[i - 2]) / 2 - a[i - 3];

            for (int i = 3; i < N + 3; i++)
                Console.Write("{0, 12:F2}", a[i]);

            
        }
    }
}
