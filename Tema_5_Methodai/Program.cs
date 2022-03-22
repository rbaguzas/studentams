using System;
using System.Collections.Generic;

namespace Tema_5_Methodai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1 = 5;
            int num2 = 10;

            //Return Methodai
            int sum = AddTwoNumbers(5, 10);
            int sum2 = AddTwoNumbers(num1, num2);

            //Void Methodai
            List<string> stringList = new List<string>();
            AddToList(stringList, "Vilnius");
            AddToList(stringList, "Kaunas");
            AddToList(stringList, "Klaipeda");

            List<string> stringList1 = AddToList("Vilnius");
            List<string> stringList2 = AddToList("Kaunas");
            List<string> stringList3 = AddToList("Klaipeda");

            //Public ir Private skirtumas
            var testClass = new Test();
            testClass.SayHelloPublic("Jonas");


            MiniCalculator("+", 9, 1);
            MiniCalculator("-", 8, 4);

            MiniCalculator2("+", 9, 1);
            MiniCalculator2("-", 8, 4);
        }

        public static int AddTwoNumbers(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public static int SubstractTwoNumbers(int x, int y) 
        {
            int diff = x - y;
            return diff;
        }

        public static void MiniCalculator(string simbolis, int x, int y) 
        {
            switch (simbolis) 
            {
                case "+":
                    int sum = AddTwoNumbers(x, y);
                    Console.WriteLine($"Suma yra: {sum}");
                    break;
                case "-":
                    int diff = SubstractTwoNumbers(x, y);
                    Console.WriteLine($"Skirtumas yra: {diff}");
                    break;
                default:
                    Console.WriteLine("Nezinomas simbolis");
                    break;
            }
        }

        //C# 8 Swtich Expression
        public static void MiniCalculator2(string simbolis, int x, int y) 
        {
            int result = simbolis switch
            {
                "+" => AddTwoNumbers(x, y),
                "-" => SubstractTwoNumbers(x, y),
                _ => 0
            };

            Console.WriteLine($"Resultas {x} {simbolis} {y} = {result}");
        }




        public static void AddToList(List<string> stringList, string stringToAdd) 
        {
            stringList.Add(stringToAdd);
        }

        public static List<string> AddToList(string stringToAdd)
        {
            List<string> stringList = new List<string>();
            stringList.Add(stringToAdd);
            return stringList;
        }
    }
}
