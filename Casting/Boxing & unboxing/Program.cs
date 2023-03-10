namespace Boxing___unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boxing 
            int number = 10; //value Type
            object obj = number; // boxing
            // object is on heap and heap is larger  and number is on stack

            // unboxing (Explict casting)
           
            int number2 = (int)obj; // unboxing

            // convert from string to numerical
            // 1). int.Parse(), 2). Convert.ToInt32()
            // int intValue = int.Parse(stringValue);  // overFlow exception
            string str = "100";
            int number3 = Convert.ToInt32(str);


            string stringValue = "9999999999999";
            if (int.TryParse(stringValue, out int intValue))
            {
                Console.WriteLine(intValue);
            }
            else
            {
                Console.WriteLine("Invalid Number does not fit integer");
            }

            // Convert Class
            var number12 = 255;
            //int is 4 bytes
            var bytes = BitConverter.GetBytes(number12);
            foreach(var b in bytes)
            {
                Console.WriteLine(b);
                var binary = Convert.ToString(b, 2).PadLeft(8, '0');
                Console.WriteLine(binary);
            }


            // from string to binary
            var name = "Afnan";
            char[] letters = name.ToCharArray();
            foreach(var b in letters)
            {
                int ascii = Convert.ToInt32(b);
               
            }
        }
    }
}