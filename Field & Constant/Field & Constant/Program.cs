namespace Field___Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Field & Constant 
            // Field: A field is a variable that is declared inside a class or struct.
            // Constant: A constant is a field that is declared with the const modifier.

            // Object syntax
            // objectName.fieldName = value;
            Employee e1 = new Employee();
            Console.WriteLine("First Employee");

            Console.WriteLine("First Name");
            e1.fName = Console.ReadLine();




            const  double TAX= 0.03;
            
            Console.WriteLine("Last Name");
            e1.lName= Console.ReadLine();

            Console.Write("wage");
            e1.wage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("logged Hours");
            var loggedHours= Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Second Employee");
            Employee e2 = new Employee();
            Console.WriteLine("First Name");
            e2.fName = Console.ReadLine();

            Console.WriteLine("Last Name");
            e2.lName = Console.ReadLine();

            Console.Write("wage");
            e2.wage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("logged Hours");
            var loggedHours2 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("First Employee Data");
          var netSalary =e1. wage * loggedHours - (e1.wage * loggedHours * Employee.TAX);
            Console.WriteLine($"First Name : {e1.fName}");
            Console.WriteLine($"Last Name : {e1.lName}");
            Console.WriteLine($"Wage: {e1.wage}");
            Console.WriteLine($"Logged Hours: {loggedHours}");
            Console.WriteLine($"Net Salary: {netSalary}");


            Console.WriteLine("Second Employee Data");
            double netSalary2 = e2.wage * loggedHours2 - (e2.wage * loggedHours2 * Employee.TAX);
            Console.WriteLine($"First Name : {e2.fName}");
            Console.WriteLine($"Last Name : {e2.lName}");
            Console.WriteLine($"Wage: {e2.wage}");
            Console.WriteLine($"Logged Hours: {loggedHours2}");
            Console.WriteLine($"Net Salary: {netSalary2}");
            Console.WriteLine(
                "Press any key to exit"
                               );

        }
    }
}