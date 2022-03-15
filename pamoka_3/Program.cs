using System;
using System.Collections.Generic;

namespace pamoka_3
{
    class Program
    {
        static void Main(string[] args)
        {

            ////VALUE TYPE
            ////Floatai ir doublai

            //float numFloat = 1F / 3;
            //double numDouble = 1D / 3;

            //if (numFloat == numDouble)
            //{
            //    Console.WriteLine($"skaiciusFloat: {numFloat}, skaiciusDouble: {numDouble}");
            //}
            //else 
            //{
            //    Console.WriteLine($"skaiciusFloat: {numFloat}, nera lygus skaiciusDouble: {numDouble}");
            //}


            ////Stringai ir Char's
            //string name = "Jonas";
            //char s = '5';


            ////byte 0 => 255
            //byte a = 0;
            //Console.WriteLine(a);

            //a++;
            //Console.WriteLine(a);

            //a = 254;
            //a++;

            //Console.WriteLine(a);

            //a++;
            //Console.WriteLine(a);

            ////sbyte -128 => 127
            //sbyte x = 126;
            //x++;
            //x++;
            //x++;

            ////Reference type
            //string lastname = "Jonas";
            //string lastname1 = null;
            //lastname1 = "petras";

            //Human human1 = new Human();
            //human1.Name = "Jonas";

            //List<string> vardai = new List<string>();

            ////Implicit casting
            //byte b = 57;
            //int i = b;
            //long l = i;
            //float f = l;

            //Console.WriteLine($"BYTE: {b}");
            //Console.WriteLine($"INT: {i}");
            //Console.WriteLine($"LONG: {l}");
            //Console.WriteLine($"FLOAT: {f}");


            ////Explicit casting
            //double y = 1234.7D;
            //int o = (int)y;
            //Console.WriteLine(o);

            ////Convert klase
            //int k = 12;
            //double d = 765.12D;
            //float fl = 56.123F;

            //string convertedString = Convert.ToString(f);
            //int convertedInt = Convert.ToInt32(d);
            //double convertedDouble = Convert.ToDouble(fl);

            ////CONDITIONS
            ////Console.WriteLine("Iveskite grupes pavadinima");
            ////string grupesPavadinimas = Console.ReadLine();

            ////Console.WriteLine("Iveskite grupes nariu skaiciu:");
            ////string inputas = Console.ReadLine();
            ////int nariusSk;
            ////bool isValidNum = int.TryParse(inputas, out int nariusSk);
            //bool isValidNum = false;

            ////int nariusSkaicius = int.Parse(Console.ReadLine());

            ////if (!isValidNum)
            ////{
            ////    Console.WriteLine("Skaicius yra neteisingas");
            ////}

            ////if (!int.TryParse(Console.ReadLine(), out int nariusSkaicius)) 
            ////{
            ////    Console.WriteLine("Ivestas nekorektiskas skaicius");
            ////    Environment.Exit(0);
            ////}


            //string spalva = Console.ReadLine();

            //if (spalva == "geltona")
            //{
            //    Console.WriteLine("Grazi spalva");
            //}
            //else if (spalva == "zalia")
            //{
            //    Console.WriteLine("Normali spalva");
            //}
            //else if (spalva == "raudona")
            //{
            //    Console.WriteLine("Labai grazi spalva");
            //}
            //else 
            //{
            //    Console.WriteLine("Nesuprantu, kas cia per spalva");
            //}

            int[] skaiciai = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = rnd.Next(1, 100);
            }
            for (int i = 0; i < skaiciai.Length; i++)
            {
                for (int j = 0; j < skaiciai.Length; j++)
                {
                    if (skaiciai[i] < skaiciai[j])
                    {
                        var k = skaiciai[i];
                        skaiciai[i] = skaiciai[j];
                        skaiciai[j] = k;
                    }
                }
            }
        }

        public class Human
        {
            public string Name;
        }
    }
}
