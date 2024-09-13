using System.ComponentModel.Design;
using System.Data;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
         Console.Write("Enter a value between 1 and 100: ");

         while (!(int.TryParse(Console.ReadLine(), out x) && (x > 0 && x < 101))) ;
        Console.Write("Der Diktator springt auf die Schüssel, da er sich vor lachen fast in die Hose macht!");
        Console.WriteLine("Der Diktator ist stolz auf dich!");*/
        
        Random NewRandom = new Random();
        int RandomNuber = NewRandom.Next(1, 100);
           int Nuber = 0;
        bool hello = false;
        while (hello = true)
        {
           
            Nuber = Convert.ToInt32(Console.ReadLine());
            else if (Nuber > RandomNuber)
            {
                hello = false;
                Console.WriteLine("The secret Number is smaller!");
            }
            else if (Nuber < RandomNuber)
            {
                hello = false;
                Console.WriteLine("The Secret Number is bigger!");
            }
            else if (Nuber == RandomNuber)
            {
                Console.WriteLine("Right Number");
                hello = true;
            }
        }
        
    }
}