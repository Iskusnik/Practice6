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
        //Сделать рекурсию

        //Строим N новых элементов
        static double AiFunc(double a1, double a2, double a3, int N)
        {
            double a4 = 0;
            if (N != 0)
            {
                a4 = (a3 + a2) / 2 - a1;
                Console.Write(a4 + " ");
                AiFunc(a2, a3, a4, N - 1);
            }
            return a4;
        }


        static string temp = "", buf = "";
        static bool used = false;

        static double max = -1234567890;

        static string AiFuncGrow(double a1, double a2, double a3, int N, string buf)
        {
            double a4 = 0;
            if (N != 0)
            {
                a4 = (a3 + a2) / 2 - a1;
                Console.Write(a4 + " ");
                if (!used)
                {
                    if (a1 < a2)
                    {
                        temp += a1.ToString() + " ";
                        max = a2;
                    }
                    else
                    {
                        temp += max.ToString() + " ";
                        used = true;
                    }
                }
                else
                {
                    if (a1 < a2)
                    {
                        buf += a1.ToString() + " ";
                        if (a2 > max)
                        {
                            temp = buf.ToString();
                            buf = "";
                            max = a2;
                            used = false;
                        }
                    }
                    else
                        buf = "";
                }     
                

                AiFunc(a2, a3, a4, N - 1);
            }
            return temp;
        }
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
            double[] b = new double[1];
            a[0] = a1;
            a[1] = a2;
            a[2] = a3;

            for (int i = 3; i < N + 3; i++)
                a[i] = (a[i - 1] + a[i - 2]) / 2 - a[i - 3];

            Console.WriteLine("Последовательность:");
            for (int i = 0; i < N + 3; i++)
                Console.Write("{0, 12:F2}", a[i]);
            Console.WriteLine("");
            Console.WriteLine("Длина последовательности: {0}", N + 3);

            
            int l = 0, r = 0, j = 0;
            b[j] = a[0];

            for (int i = 0; i < N + 2; i++)
                if (a[i] < a[i + 1])                            //Нашли участок возрастания
                {
                    l = i;                                      // Отрезок возрастания задаётся
                                                                // l - левая граница, r - правая граница
                    for (r = i + 1; a[r] > a[r - 1]; r++) ;     // Ищем правую границу
                    i = r;                                      // Сдвигаем указатель
                    r--;                                        // Уточняем границу (пример: 2 3 1, После прохода, указатель остаётся на 1, надо сдвинуть на элемент влево

                    if (b[j] < a[r])                            // Сравниваем с последней сохранённой последовательностью
                    {
                        b = new double[r - l + 1];
                        for (j = 0; j <= r - l; j++)
                            b[j] = a[l + j];
                        j = b.Length - 1;
                    }

                }
                else
                    continue;

            Console.WriteLine("");
            Console.WriteLine("Максимально возрастающая подпоследовательность:");
            for (int i = 0; i < b.Length; i++)
                Console.Write("{0, 12:F2}", b[i]);
            Console.WriteLine("");
            Console.WriteLine("Длина подпоследовательности: {0}", b.Length);

            Console.WriteLine("Максимальный элемент: {0}", b.Last());

        }
    }
}
