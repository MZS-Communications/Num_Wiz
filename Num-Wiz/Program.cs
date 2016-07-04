using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using UnityEngine;


namespace Num_Wiz
{
    class Program
    {
         

       
        static void Main(string[] args)
        {
            int StartGame ;
            int max, min, guess;
        
            max = 1000;
            min = 1;
            guess = 500;
            string test = "'y";
            string de = "";
        

            
            //int guess2 = 0;
            ////int Max = 0;
            //bool canGuess = false;
            //bool setMax = false;
            //bool setMin = false;


            Program pro = new Program();


            Console.WriteLine("Welcome to the Wizard Game");
           
            
           
            //Console.WriteLine("Set a max number");
           // Console.ReadLine();
            //setMax = true;

            Console.WriteLine("Pick a number in your head between 1-1000, but don't tell me!");

          

             //max = max + 1;

            guess = pro.Range(min,max);
             //Random r = new Random(min,max);
            Console.WriteLine("Please Use UpArrow for Higher");
            Console.WriteLine("Please Use DownArrow for Lower");
            Console.WriteLine("Please Use Spacebar or Enter for Equal");
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
          
           
            Console.WriteLine("Is the number higher or lower than " + guess + "?");
            //guess = Convert.ToInt32(Console.ReadLine());

         ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;


            for (int i = 0; i < 10; i++)
            {
                cki = Console.ReadKey();
                // Console.Write(" The number is ");

                //max = max + 1;
                // guess = pro.Range(min, max);
                if (cki.Key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("Higher");
                    guess = guess + pro.Range(1, 9);
                    //NextGuess(min, max,guess);
                }
                else
                    if (cki.Key == ConsoleKey.DownArrow)
                    {
                        Console.WriteLine("Lower");
                        guess = guess - pro.Range(1, 9);

                    }
                    else
                        if (cki.Key == ConsoleKey.Spacebar)
                        {
                            Console.WriteLine("I Won!");
                            // min = guess;
                            //NextGuess(min, max, guess);
                           // Console.ReadKey();
                           
                            Console.WriteLine("Would you like to play again Y/N?");
                            de = Console.ReadLine();

                            if (test == de)
                            {

                                i = 0;
                                //de = Console.ReadLine()
                            }
                            else
                            {
                                    Console.WriteLine("Thank You for Playing, hope you had fun");
                                    Console.ReadKey();
                                   // Console.WriteLine("Would you like to play again Y/N?");
                                    i = 10;
                                    // de = Console.ReadLine();

                                } 

                        }
                        //else
                        //    if (cki.Key == ConsoleKey.Enter)
                        //    {
                        //        Console.WriteLine("I Won!");
                        //        i = 10;
                        //        Console.WriteLine("Would you like to play again Y/N?");
                        //        de = Console.ReadLine();
                        //        if (test == de)
                        //        {
                                    
                        //            i = 0;
                        //            //de = Console.ReadLine()
                        //        }
                        //        else
                        //            if (i == 9)
                        //            {
                        //                Console.WriteLine("Thank You for Playing, hope you had fun");
                        //                Console.WriteLine("Would you like to play again Y/N?");
                        //                i = 10;
                        //               // de = Console.ReadLine();

                        //            } 

                           // }
                Console.WriteLine("Is the number higher or lower than " + guess + "?");
               

                if (i==9)
                {

                    if (test == de)
                    {
                        Console.WriteLine("Would you like to play again Y/N?");
                        i = 0;
                        de = Console.ReadLine();



                    }
                    else
                        if (i == 9)
                        {

                            Console.WriteLine("You have no more moves, sorry you loose");
                            Console.WriteLine("Thank You for Playing, hope you had fun");
                            Console.WriteLine("Would you like to play again Y/N?");
                            i = 10;
                            de = Console.ReadLine();

                        } 
                }

             
            }
          
        }
    
   public int Range(int num1, int num2)
  {
                Random r = new Random();

                int num=   r.Next(num1, num2);
            

            return num;
  }
}

}
