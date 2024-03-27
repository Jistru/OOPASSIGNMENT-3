using System;
//Coded by; Diaz, Jestro R.
//From: BSCPE 1-1

namespace OOPASSIGNMENT3NIJES
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Choose an Option (a to d):" +
                "\na. (Seconds to Minutes)" +
                "\nb. (Minutes to Hours)" +
                "\nc. (Hours to Days)" +
                "\nd. (Days to Months)" +
                "\nChoose from (a to d):");
            String Pogi = Console.ReadLine();

            if (Pogi == "a")
            {
                Console.Write("Put a number of second/s to convert:");
                int UserNum = Convert.ToInt32(Console.ReadLine());
                int m = 60;
                int Op1;
                int Op2;
                Op1 = UserNum / m; 
                Op2 = UserNum % m;

                Console.WriteLine(UserNum + " second/s to minute/s is: " + Op1 + " minute/s and " + Op2 + " seconds ");
            }
            else
            {

                if (Pogi == "b") 
                {
                    Console.Write("Put a number of minute/s to convert:");
                    int UserNum = Convert.ToInt32(Console.ReadLine());
                    int h = 60;
                    int Op1;
                    int Op2;
                    Op1 = UserNum / h;
                    Op2 = UserNum % h;
                    Console.WriteLine(UserNum + " minute/s to hour/s is: " + Op1 + " hour/s and " + Op2 + " minute/s ");
                }
                else
                {
                    if (Pogi == "c")
                    {
                        Console.Write("Put a number of hour/s to convert: ");
                        int UserNum = Convert.ToInt32(Console.ReadLine());
                        int d = 24;
                        int Op1;
                        int Op2;
                        Op1 = UserNum / d;
                        Op2 = UserNum % d;
                        Console.WriteLine(UserNum + " hour/s in day/s is: " + Op1 + " day/s and " + Op2 + " hour/s ");
                    }
                    else
                    {
                        if (Pogi == "d")
                        {
                            Console.Write("Put a number of day/s to convert:");
                            int UserNum = Convert.ToInt32(Console.ReadLine());
                            int m = 30;
                            int Op1;
                            int Op2;
                            Op1 = UserNum / m;
                            Op2 = UserNum % m;
                            Console.WriteLine(UserNum + " day/s in month/s is: " + Op1 + " month/s and " + Op2 + " day/s ");
                        }
                        else
                        {
                            Console.Write("Oops! Looks like you picked something outside the options. Try entering a, b, c, or d.");
                            return;
                        }
                    }
                }

            }
        }
    }

}