using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print<int>(1);
            Print("Afnan");
            Print(50.000);
            Print('F');
            // declare a list of type int
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            Console.WriteLine(list1);
            //declare a list of type string 
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("Afnan");
            list2.Add("Aya");
            list2.Add("Mahmoud");
            // declare a list of type any class
            GenericList<SampleClass> list3 = new GenericList<SampleClass>();
            SampleClass s1 = new SampleClass();
            SampleClass s2 = new SampleClass();
            list3.Add(s1);
            list3.Add(s2);


            // using collections 
            List<int> list4 = new List<int>();
            list4.Add(1);
            list4.Add(3);
            list4.Add(5);
            foreach(var item in list4)
            {
                Console.WriteLine($" int Item = {item}");
            }

            List<string> list5 = new List<string>();
            list5.Add("Afnan");
            list5.Add("Aya");
            list5.Add("Mahmoud");
            foreach (var item1 in list5)
            {
                Console.WriteLine($" String Item = {item1}");
            }

            List<SampleClass> list6 = new List<SampleClass>();
            SampleClass s6 = new SampleClass();
            list6.Add(s6);


        }



        #region Generic Method
        static void Print<T>(T value)
        {
            Console.WriteLine(typeof(T));
        }
    }

    #endregion
}