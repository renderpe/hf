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

            //Задание 1

            //int count = 0;

            //while (count < 10)

            //{

            //    Console.WriteLine("Привет");

            //    count++;

            //    Console.ReadLine();



            //Задание 2

            //int count = 0;

            //do

            //{

            //    Console.WriteLine(count);

            //    count++;

            //} while (count <= 9);

            //Console.ReadLine();



            //Задание №2

            //int[] omas = new int[8];

            //Console.WriteLine("Заполнение о.м.");

            //for (int i = 0; i < 8; i++)

            //{

            //    Console.WriteLine($"omas[{i}]=");

            //    omas[i] = int.Parse(Console.ReadLine());

            //}

            //Console.WriteLine("Вывод о.м");

            //for (int i = 0; i < 8; i++)

            //{

            //    Console.WriteLine($"omas [{i}]={omas[i]}");

            //}

            //    Console.Read();



            //Задание №3

            int[] omas = new int[12];

            Random rnd = new Random();

            for (int i = 0; i < omas.Length; i++)

            {

                omas[i] = rnd.Next(163, 190);

            }

            foreach (var element in omas)

            {

                Console.Write($"{element}\t");

            }

            Console.Read();

        }

    }

}

