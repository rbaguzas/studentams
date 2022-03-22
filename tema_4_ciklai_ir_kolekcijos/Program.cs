using System;
using System.Collections.Generic;
using System.IO;

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

            //Masyvo dydzio keitimas
            Console.Clear();
            char[] zodis = new char[6];

            zodis[0] = 'K';
            zodis[1] = 'u';
            zodis[2] = 'r';
            zodis[3] = 's';
            zodis[4] = 'a';
            zodis[5] = 's';

            foreach (var raide in zodis)
            {
                Console.WriteLine(raide);
            }

            Array.Resize(ref zodis, 8);

            zodis[6] = 'C';
            zodis[7] = '#';

            foreach (var raide in zodis)
            {
                Console.WriteLine(raide);
            }


            //1. Uzduotis
            Console.Clear();

            int[] kolekcija = { 1, 5, 8, 1, 5 };

            int[] kolekcija3 = new int[5];

            //for (int i = 0; i < kolekcija3.Length; i++)
            //{
            //    int vartotojoSkaicius = int.Parse(Console.ReadLine());
            //    kolekcija3[i] = vartotojoSkaicius;
            //}

            for (int i = kolekcija.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Ciklas mazeja. Siuo metu yra: {kolekcija[i]}");
            }

            //2. Uzduotis
            Console.Clear();
            int[] kolekcija2 = { 1, 1, 1, 1, 5 };
            int sum = 0;

            for (int i = 0; i < kolekcija2.Length; i++)
            {
                sum += kolekcija2[i];
            }

            Console.WriteLine($"Suma yra: {sum}");

            //3. Uzduotis
            Console.Clear();
            int[] userInput = { 5, 9, 10 };

            foreach (var number in userInput)
            {
                Console.WriteLine(number);
            }

            int num4 = 99;
            int num5 = 168;

            Array.Resize(ref userInput, 5);

            userInput[3] = num4;
            userInput[4] = num5;

            //5. Uzduotis
            Console.Clear();

            int[] numArray = new int[10];
            int[] numArray2 = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = rnd.Next(1, 100);
                numArray2[i] = rnd.Next(1, 100);
            }

            int[] concatedArray = new int[numArray.Length + numArray2.Length];
            numArray.CopyTo(concatedArray, 0);
            numArray2.CopyTo(concatedArray, numArray.Length);

            foreach (var item in concatedArray)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < concatedArray.Length; i++)
            {
                for (int j = i + 1; j < concatedArray.Length; j++)
                {
                    if (concatedArray[i] > concatedArray[j]) 
                    {
                        int temp = concatedArray[i];
                        concatedArray[i] = concatedArray[j];
                        concatedArray[j] = temp;
                    }
                }
            }


            //6. Uzduotis

            char[] zodis2 = new char[6];

            zodis2[0] = 'K';
            zodis2[1] = 'u';
            zodis2[2] = 'r';
            zodis2[3] = 's';
            zodis2[4] = 'a';
            zodis2[5] = 's';

            char[] naujasZodis = new char[zodis2.Length - 1];

            int m = 0;
            int n = 0;
            int removeAt = 1;

            while (m < zodis2.Length) 
            {
                if (m != removeAt) 
                {
                    naujasZodis[n] = zodis2[m];
                    n++;
                }

                m++;
            }


            #endregion

            #region List<T>

            List<string> listas = new List<string>();
            List<int> intList = new List<int>();
            List<decimal> decimalList = new List<decimal>();
            List<bool> booList = new List<bool>();
            List<object> objectList = new List<object>();

            objectList.Add(true);
            objectList.Add("true");
           
            booList.Add(true);

            //Listo pildymas
            listas.Add("Jonas");
            listas.Add("Petras");
            listas.Add("Juozas");

            List<string> listas2 = new List<string> { "Jonas", "Petras", "Juozas" };

            //for (int i = 0; i < listas.Count; i++)
            //{
            //    Console.WriteLine(listas[i]);
            //}

            //foreach (var item in listas)
            //{
            //    Console.WriteLine(item);
            //}

            //listas.RemoveAt(5);

            //listas.Insert(5, "Onute");
            listas.AddRange(listas2);
            bool isContains = listas.Contains("Petras");
            int indexas = listas.LastIndexOf("Petras");


            //Listai. 8. Uzduotis
            Console.Clear();
            List<string> countries = new List<string>();
            string path = "C:\\Users\\laimo\\Documents\\GitHub\\https---github.com-LaimonasCiurlionis-studentams.git\\tema_4_ciklai_ir_kolekcijos\\countries.txt";
            string destinationPath = "C:\\Users\\laimo\\Documents\\GitHub\\https---github.com-LaimonasCiurlionis-studentams.git\\tema_4_ciklai_ir_kolekcijos\\countries_sorted.txt";

            using (StreamReader countriesFile = new StreamReader(path)) 
            {
                string readLine;

                while ((readLine = countriesFile.ReadLine()) != null) 
                {
                    countries.Add(readLine);
                }
            }

            countries.Sort();

            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }

            using (StreamWriter sw = File.CreateText(destinationPath));

            File.WriteAllLines(destinationPath, countries);

            Console.WriteLine($"Is viso saliu: {countries.Count}");


            





            #endregion
        }
    }
}
