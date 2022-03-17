using System;

namespace tema_4_ciklai_ir_kolekcijos
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Ciklai

            //Paprastas ciklas (Didejantis)
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Sukasi ciklas. Siuo metu yra: {i}");
            }

            //Mažėjantis ciklas
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Ciklas mazeja. Siuo metu yra: {i}");
            }

            //Ciklas su žingsniu
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine($"Sukasi ciklas. Siuo metu yra: {i}");
            }

            //Iteracijos per simbolių diapazoną
            for (char i = 'a'; i <= 'z'; i++)
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

            #endregion

            #region Kolekcijos (Collections)

            Console.Clear();

            string[] savaitesDienos = {
                "pirmadienis",
                "antradienis",
                "treciadienis",
                "ketvirtadienis",
                "penktadienis",
                "sestadienis",
                "sekmadienis",
            };

            for (int i = 0; i < savaitesDienos.Length; i++)
            {
                Console.WriteLine(savaitesDienos[i]);
            }

            int[] ints = { 1, 5, 6 };

            string pirmadienis = savaitesDienos[0];

            Console.WriteLine("Kuria savaites diena parodyti");
            Console.WriteLine("Pirmadienis - 1 ir tt.");

            int index = 5;
            string selectedDay = savaitesDienos[index - 1];

            Console.WriteLine($"Buvo pasirinkta diena: {selectedDay}");

            //Elemento keitimas masyve
            Console.Clear();

            Console.WriteLine("Pries:");

            foreach (var diena in savaitesDienos)
            {
                Console.WriteLine(diena);
            }

            savaitesDienos[2] = "TRECIADIENISSSSS";

            Console.WriteLine("Po:");

            foreach (var diena in savaitesDienos)
            {
                Console.WriteLine(diena);
            }

            //Masyvo uzpildymas atsitiktiniais skaiciais
            Console.Clear();
            int[] skaiciai = new int[10];
            string[] t = new string[10];

            Random random = new Random();

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = random.Next(1, 100);
            }

            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine(skaicius);
            }

            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine(skaicius);
            }

            #endregion
        }
    }
}
