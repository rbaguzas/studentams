using System;

namespace tema_4_ciklai_ir_kolekcijos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paprastas ciklas (Didejantis)
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Sukasi ciklas. Siuo metu yra: {i}");
            }

            //Mažėjantis ciklas
            for (int i = 10; i >= 0 ; i--)
            {
                Console.WriteLine($"Ciklas mazeja. Siuo metu yra: {i}");
            }

            //Ciklas su žingsniu
            for (int i = 0; i < 10; i +=2)
            {
                Console.WriteLine($"Sukasi ciklas. Siuo metu yra: {i}");
            }

            //Iteracijos per simbolių diapazoną
            for (char i = 'a';  i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            //Iteracija per stringą
            string name = "Petriukas";
            int length = name.Length;

            for (int i = 0; i < name.Length; i++)
            {
                char current = name[i];
                Console.WriteLine(current);
                Console.WriteLine(i);
            }

            //for (; ; )
            //{
            //    Console.WriteLine("AMŽINAI");
            //}

            Console.Clear();

            //Pabėgimas iš ciklo BREAK
            for (int i = 0; i < name.Length; i++)
            {
                char current = name[i];

                if (current == 'u') 
                {
                    break;
                }

                Console.WriteLine(current);
            }

            Console.Clear();

            //Ciklo pratęsimas Continue
            for (int i = 0; i < name.Length; i++)
            {
                char current = name[i];

                if (current == 'u')
                {
                    continue;
                }

                Console.WriteLine(current);
            }

            foreach (char simbolis in name)
            {
                Console.WriteLine(simbolis);
            }

            //int[] b = new int [10];

            //b[]
        }
    }
}
