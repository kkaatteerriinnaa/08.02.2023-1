using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите число:");
            //int Num = int.Parse(Console.ReadLine());
            //if (Num <= 100 && Num > 0)
            //{
            //    if (Num / 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    if (Num / 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    if (Num / 2 == 0 && Num / 5 == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz");
            //    }
            //    if (Num / 2 != 0 && Num / 5 != 0)
            //    {
            //        Console.WriteLine(Num);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            //Console.WriteLine("Введите первое число:");
            //int A = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число:");
            //int B = int.Parse(Console.ReadLine());
            //int C = A * B / 100;
            //Console.WriteLine(C);

            //int[] arr = new int[6];
            //int a, b, tmp;
            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.WriteLine(i + 1);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Введите первое число:");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число:");
            //b = int.Parse(Console.ReadLine());
            //tmp = arr[a];
            //arr[a] = arr[b];
            //arr[b] = tmp;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Console.WriteLine("С - 1, F - 0");
            //bool a = bool.Parse(Console.ReadLine());
            //if(a)
            //{
            //    Console.Write("Введите температуру в градусах Цельсия: ");
            //    double c = Convert.ToDouble(Console.ReadLine());
            //    double f = c * 9 / 5 + 32;
            //    Console.WriteLine("Температура по Фаренгейту равна: {0}", f);
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.Write("Введите температуру в градусах Фаренгейта: ");
            //    double c = Convert.ToDouble(Console.ReadLine());
            //    double f = c / 9 * 5 - 32;
            //    Console.WriteLine("Температура по цельсия равна: {0}", f);
            //    Console.ReadKey();
            //}

         
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

           if(a>b)
           {
                int tmp = 1;
                a = b;
                b = tmp;
           }
           for(int i=a;i<=b;i++)
           {
                if(i/2==0)
                {
                    Console.Write(i+" ");
                }
                
           }
        }
    }
}
