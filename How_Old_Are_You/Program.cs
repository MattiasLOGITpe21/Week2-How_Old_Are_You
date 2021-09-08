using System;

namespace How_Old_Are_You
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm arvutab kasutaja sünniaasta
            //programm kuvab kasutaja sünniaasta konsoolis

            Console.WriteLine("Kui vana sa oled?");
            //convert string from ReadLine() to int
            int Age = Convert.ToInt32 (Console.ReadLine());

            int YearOfbirth = 2021 - Age;

            Console.WriteLine($"sa sündisid aastal {YearOfbirth}.");
            Console.ReadLine();




            


        }
    }
}
