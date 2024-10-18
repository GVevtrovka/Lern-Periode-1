namespace Erfolgloses_Projekt
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Random NewRandom = new Random();
            int RandomNumber = NewRandom.Next(1, 100);
            bool repeat = true;
            int Number;
            string NumberinString;
            int versuche = 0;

            Console.WriteLine("Enter a Number: ");
            int enteredshit = 0;

            while (repeat == true)
            {


                NumberinString = Console.ReadLine();

                if (Int32.TryParse(NumberinString, out Number))
                {

                }
                
                else
                {
                    Console.WriteLine("Strings are Unnececary!");
                    versuche++;
                    enteredshit++;
                    Console.WriteLine("Anzahl Versuche: " + versuche);
                    Thread.Sleep(1500);
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.WriteLine("Now enter a valid Number: ");
                    continue;
                }
                
                if (Number > 0)
                {
                }
                
                else
                {
                    Console.WriteLine("Your Number is Deeper than the set Range!");
                    versuche++;
                    enteredshit++;
                    Console.WriteLine("Anzahl Versuche: " + versuche);
                    Thread.Sleep(1500);
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.WriteLine("Enter a Number between 1 and 100: ");
                    continue;
                }
                
                if (Number < 101)
                {
                }
                
                else
                {
                    Console.WriteLine("Your Number is Higher than the set Range!");
                    versuche++;
                    enteredshit++;
                    Console.WriteLine("Anzahl Versuche: " + versuche);
                    Thread.Sleep(1500);
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.WriteLine("Enter a Number between 1 and 100: ");
                    continue;
                }

                if (Number > RandomNumber)
                {
                    repeat = true;
                    Console.WriteLine("The secret Number is smaller!");
                    versuche++;
                }
                
                else if (Number < RandomNumber)
                {
                    repeat = true;
                    Console.WriteLine("The Secret Number is bigger!");
                    versuche++;
                }
                
                else if (Number == RandomNumber)
                {
                    Console.WriteLine("Right Number");
                    repeat = false;
                    versuche++;
                }

                if (repeat == false)
                {
                    Random random = new Random();
                    int randomly = random.Next(1, 3);
                    
                    if (randomly == 1)
                    {
                        
                        if (enteredshit > 0)
                        {
                            Console.WriteLine("You are shit and entered " + enteredshit + " times a not valid variable! YOU ARE AN IDIOT!");
                            continue;
                        }
                    }
                    
                    if (randomly == 2)
                    {
                        
                        if (enteredshit > 0)
                        {
                            Console.WriteLine("You 3 year old Idiot you entered  " + enteredshit + " times a not valid variable! Why you are so dumb?");
                            continue;
                        }
                        
                        if (randomly == 3)
                        {
                            
                            if (enteredshit > 0)
                            {
                                Console.WriteLine("This Idiot entered" + enteredshit + " times a wrong variable!");
                                continue;
                            }
                        }
                    }
                }

                if (repeat == true)
                {
                    Console.WriteLine("Anzahl Versuche: " + versuche);
                    Thread.Sleep(1500);
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.WriteLine("Enter a new Number");
                }
            }
        }
    }
}
