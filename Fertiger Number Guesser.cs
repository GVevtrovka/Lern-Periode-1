using System.ComponentModel.Design;

namespace ConsoleApp8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*  Console.WriteLine("Hello, World!");*/

            /*Console.WriteLine(RandomNuber);*/
            /*string saidNumber = Console.ReadLine();/*
            /*while int.TryParse(saidNumber, out int nuber);*/
            /*(nuber == (1, 100))*/
            /*Console.WriteLine("Number!");*/
            /*int x = 0;
             Console.Write("Enter a value between 1 and 100: ");*/

             /*else if(!(int.TryParse(Console.ReadLine(), out x) && (x > 0 && x < 101)));
            Console.Write("Der Diktator springt auf die Schüssel, da er sich vor lachen fast in die Hose macht!");
            Console.WriteLine("Der Diktator ist stolz auf dich!");*/

            Random NewRandom = new Random();
            int RandomNuber = NewRandom.Next(1, 100);
            bool repeat = true;
            int Nuber;
            bool mama = false;

            while (repeat == true)
            {
                mama = false;
                 
                if (int.TryParse(Console.ReadLine(), out Nuber) && (Nuber > 0 && Nuber < 101))
                {
                    mama = true;
                }
                else if (mama == false)
                {
                    Console.WriteLine("Don't enter Strings, Numbers below 0 or Numbers higher than 100!");
                    Console.WriteLine("Der Diktator springt auf die Schüssel, da er sich vor lachen fast in die Hose macht.");
                    continue;
                }

                if (Nuber > RandomNuber)
                {
                    repeat = true;
                    Console.WriteLine("The secret Number is smaller!");
                }
                else if (Nuber < RandomNuber)
                {
                    repeat = true;
                    Console.WriteLine("The Secret Number is bigger!");
                }
                else if (Nuber == RandomNuber)
                {
                    Console.WriteLine("Right Number");
                    repeat = false;
                }



            }

        }
    }
}