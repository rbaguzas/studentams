using System;

namespace pamoka_antra
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Uzduotis
            int x = 10;
            int y = 20;
            int temp;

            //Console.WriteLine("PRIES");
            //Console.WriteLine($"X : {x}");
            //Console.WriteLine($"Y : {y}");

            temp = x;
            x = y;
            y = temp;

            //Console.WriteLine("PO");
            //Console.WriteLine($"X : {x}");
            //Console.WriteLine($"Y : {y}");

            //2. Uzduotis
            string schoolName = "CodeAcademy";
            string courseName = "C# kursas";
            DateTime dateNow = DateTime.Now;
            string dateNowFormatted = dateNow.ToString("MM/dd/yyyy");


            //3. Uzduotis
            DateTime courseStartDate = new DateTime(2022, 03, 01);
            DateTime courseEndDate = new DateTime(2022, 10, 25);
            double totalDaysDiff = (courseEndDate - courseStartDate).TotalDays;
            double totalWeeksDiff = totalDaysDiff / 7;


            //Inicializacija
            int yearOfBirth;
            string firstName;

            //Deklaravimas
            var lastName = "Paverdeninas";
            decimal salary = 10m; //Darbui su pinigais
            double number = 5000d; //Darbui skaiciams su liekana

            //Reiksmes priskyrimas
            yearOfBirth = 1990;
            firstName = "Vardenis";

            DateTime lastPayDay = new DateTime(2021, 03, 07);
            DateTime lastPayDay2 = DateTime.Now;

            string data = lastPayDay2.ToLongDateString();
            string dataString = lastPayDay2.ToString("dd");

            //Console.WriteLine(data);
            //Console.WriteLine($"Vardas: {firstName}");
            //Console.WriteLine("Gimimo metai: {0}, {1}", yearOfBirth, firstName);
            //Console.WriteLine($"Paskurini karta ismoketa alga {lastPayDay2}");


            //LOGINIAI OPERATORIAI
            bool A1 = false;
            bool B1 = false;

            bool A1_OR_B1 = A1 || B1; //=> FALSE
            bool A1_AND_B1 = A1 && B1; //=> FALSE
            bool A1_NOT = !A1; // => TRUE

            bool A2 = true;
            bool B2 = false;

            bool A2_OR_B2 = A2 || B2; //=> TRUE
            bool A2_AND_B2 = A2 && B2; //=> FALSE
            bool A2_NOT = !A2; //=> FALSE

            bool A3 = true;
            bool B3 = true;

            bool A3_OR_B3 = A3 || B3; //=> TRUE
            bool A3_AND_B3 = A3 && B3; //=>  TRUE
            bool A3_NOT = !A3; //=> FALSE


            bool A3_OR_B3_2 = !(!(A3 || B3) && (A3 && B3)) ; //=> TRUE


            string userInput = "Raudona";
            string raudona = "Raudona";
            string juoda = "Juoda";
            string ruzava = "Ruzava";

            bool arRaudonaSpalva = userInput == raudona;
            bool arJuodaSpalva = userInput == juoda;

            //if (arRaudonaSpalva || arJuodaSpalva || userInput == ruzava)
            //{
            //    Console.WriteLine("Grazi spalva");
            //}
            //else 
            //{
            //    Console.WriteLine();
            //}

            string userInput2 = "AB";
            //bool isValidNumber = Int32.TryParse(userInput2, out int number2);

            //if (isValidNumber)
            //{
            //    Console.WriteLine(number2 * 5);
            //}
            //else 
            //{
            //    Console.WriteLine("Blogas inputas.");
            //}



            //4. Uzduotis.
            //Console.WriteLine("Sveiki, iveskite pirma skaiciu");
            //string input1 = Console.ReadLine();

            //int number1;
            //bool isValidNumber = Int32.TryParse(input1, out number1);

            //if (isValidNumber)
            //{
            //    Console.WriteLine("iveskite antra skaiciu");
            //    string input2 = Console.ReadLine();

            //    isValidNumber = Int32.TryParse(input2, out int number2);

            //    if (isValidNumber)
            //    {
            //        bool isEqual = number1 == number2;

            //        Console.WriteLine($"Sie skaiciai: {number1}, {number2} yra {isEqual}");
            //    }
            //    else
            //    {

            //        Console.WriteLine("Blogas ivestas inputas");
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("Blogas ivestas inputas");
            //}



            //7. Uzduotis
            //Console.WriteLine("Iveskite skaiciu");
            //string input = Console.ReadLine();

            //int number2;
            //double numberDouble;
            //bool isValidNumber = Int32.TryParse(input, out number2);
            //bool isValidDouble = Double.TryParse(input, out numberDouble);

            //if (isValidDouble) 
            //{
            //    Console.WriteLine($"Sis skaicius: {numberDouble} yra su kableliu");
            //}


            //if (isValidNumber) 
            //{
            //    bool arMazesnisUzNuli = number2 < 0;
            //    bool arDidesnisUzNuli = number2 > 0;

            //    if (arMazesnisUzNuli) 
            //    {
            //        Console.WriteLine($"Skaicius yra mazesnis uz nuli");
            //    }

            //    if (arDidesnisUzNuli) 
            //    {
            //        Console.WriteLine("Skaicius yra didesnis uz nuli");
            //    }
            //}


            //8. Uzduotis.
            string inputVardas = "jONaS";
            string vardas = "Jonas";

            string inputPavarde = "jOnauSkas";
            string pavarde = "Jonauskas";

            bool arSutampaVardas = string.Equals(inputVardas, vardas);
            bool arSutampPavarde = string.Equals(inputPavarde, pavarde, StringComparison.OrdinalIgnoreCase);

            if (arSutampaVardas) 
            {
                Console.WriteLine("Vardas sutampa");
            }

            if (arSutampPavarde)
            {
                Console.WriteLine("Pavarde sutampa");
            }
        }
    }
}
