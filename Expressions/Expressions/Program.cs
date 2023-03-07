using System.Diagnostics.Metrics;

namespace Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NULL coalescing operator??
            string s1 = null;
            s1 = s1 ?? "Afnan";
            Console.WriteLine(s1);
            /* conditional null 
            Empty string is not null 
             we have null refrence exception*/
            string s2 = null;
            // Null conditonal Oprator

            var s3 = s2?.ToUpper();
            Console.WriteLine(s3);

            /*************/
            var s4 = s2 is null ? null : s2.ToUpper();
            Console.WriteLine(s4);
            /*************/
            // Expression Statement
            var name = "Afnan";
            name = name + 'A';
            name = name.ToUpper();
            Console.WriteLine(name);
            /*************/

            //Increament / Decreament Operator
            var totalFriends = 150;
            ++totalFriends;
            Console.WriteLine(totalFriends); //151
            --totalFriends;
            Console.WriteLine(totalFriends); //150

            var x = 2;
            Console.WriteLine(x++); //2
            Console.WriteLine(x);//3

            // Object Instansiation Operator
            // Selection Statement

            var mark = 90;
            if (mark == 100)
            {
                Console.WriteLine("Excellent");
            }
            else if (mark >= 90)
            {
                Console.WriteLine("Very Good");
            }
            else if (mark >= 80)
            {
                Console.WriteLine("Good");
            }
            else if (mark >= 70)
            {
                Console.WriteLine("Fair");
            }
            else if (mark >= 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            // Switch
            var amount = 100;
            var currentType = "USD";
            var output = 0.0;
            switch (currentType)
            {
                case "USD":
                    output = amount * 3.75;
                    break;
                case "EUR":
                    output = amount * 4.23;
                    break;
                case "GBP":
                    output = amount * 5.12;
                    break;
                default:
                    output = amount;
                    break;
            }
            // another way to write switch
            var cardNumber = 13;
            string cardName = cardNumber switch
            {
                1 => "Ace",
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                _ => cardNumber.ToString()
            };
            Console.WriteLine(cardName);

            /**************/

            //Iteration 
            // test first and excusion
            var counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter++);

            }
            /*********/
            counter = 0;
            do
            {
                Console.WriteLine();

            } while (true);

            /************/
            //for loop
            for(int  i = 0; i < 10; i++) {
            
            }

        }


    }
}