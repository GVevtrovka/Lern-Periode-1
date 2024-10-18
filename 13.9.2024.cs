namespace ConsoleApp8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
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
