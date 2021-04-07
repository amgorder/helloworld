using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region comments
            //this code prints to the "Hello World! to the cmd prompt
            /* using the forward slash and astrix 
            will comment out multiple lines */
            #endregion

            int myFavNum = 13;
            System.Console.WriteLine(myFavNum);
            //using int declares this variable a type of intiger
            //numbers between -2 billion and change to +2 billion and change
            //has to be a whole number
            int myFavNum1 = 10 + 3;
            System.Console.WriteLine(myFavNum1);
            int myFavNum2 = 4 * 3 + 1;
            System.Console.WriteLine(myFavNum2);
            int myFavNum3 = 4 * (2 + 1) + 1;
            System.Console.WriteLine(myFavNum3);
            //division is done with intigers and you will loose the decimal
            int myFavNum4 = 10 / 3;
            System.Console.WriteLine(myFavNum4);
            //should get 3.3333 ?
            decimal myFavNum5 = 10 / 3;
            System.Console.WriteLine(myFavNum5);

            //must have a f at the end of the number
            float myFavFloat = 3.14f;
            System.Console.WriteLine(myFavFloat);
            //must have a m at the end of the number
            decimal myFavDec = 3.123456789m;
            System.Console.WriteLine(myFavDec);

            //using string declares this variable a type of string
            //letters and more " " 
            string myFavCol = "Black" + " " + "Gold";
            System.Console.WriteLine(myFavCol);
            string myFavText = "Stay" + " " + "Golden";
            System.Console.WriteLine(myFavText);
            System.Console.WriteLine("Hey Ponyboy! {0} {1}", myFavText, myFavCol);
            System.Console.WriteLine($"Hey PonyBoy!{myFavText}");

            //True false boolean use
            bool isTrue = true;
            System.Console.WriteLine(isTrue);

            //Control Flow: Conditionals
            if (isTrue == true)
            {
                System.Console.WriteLine("This statement is true.");
            }
            // you can use   || for "or"    && for "and"   in the checks
            System.Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            if (name == "")
            {
                System.Console.WriteLine("I didn't hear you.");
            }
            else if (name == "Aaron")
            {
                System.Console.WriteLine($"Hello Boss!");
            }
            else if (name == "Jack Skullington")
            {
                System.Console.WriteLine($"Hello Alter Ego!");
            }
            else
            {
                System.Console.WriteLine($"Hello {name}");
            }


            //switch
            System.Console.WriteLine("What day of the week is it?");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "monday":
                    System.Console.WriteLine("5 until the weekend");
                    break;
                case "tuesday":
                    System.Console.WriteLine("4 until the weekend");
                    break;
                case "Wednesday":
                    System.Console.WriteLine("3 until the weekend");
                    break;
                case "thursday":
                    System.Console.WriteLine("2 until the weekend");
                    break;
                case "friday":
                    System.Console.WriteLine("1 until the weekend");
                    break;
                case "saturday":
                    System.Console.WriteLine("it's the  weekend");
                    break;
                case "sunday":
                    System.Console.WriteLine("it's the the weekend");
                    break;
                default:
                    System.Console.WriteLine("That's a No Go ghostrider.");
                    break;
            }
            System.Console.WriteLine("Goodbye");

        }
    }
}
