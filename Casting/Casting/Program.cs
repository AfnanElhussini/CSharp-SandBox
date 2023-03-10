namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit Casting (automatically) - converting a smaller type to a larger type size

            int numberInt = 100;
            long numberLong = numberInt;

            //-------------------------------
            long nL = 1000;
            //  int nI= nl; // Compilation error can not implicitly convert type 'long' to 'int'. An explicit conversion exists (are you missing a cast?)

            // we can use Explict casting to convert a larger type to a smaller type size
            
            if (nL <= long.MaxValue)
            {
                int nI = (int)nL;

            }
            //another example
            double d = 1234.8;
            int i = (int)d;
            Console.WriteLine(i);
        }
    }
}