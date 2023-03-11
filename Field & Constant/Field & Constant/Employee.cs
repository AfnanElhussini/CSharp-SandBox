using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field___Constant
{
    // Access modifier class modifiers >> public , internal is default
    // class block >> { }
    // class name >> Employee
    // class body >> { }
    // class members >> fields, properties, methods, events, constructors, indexers, operators, finalizers, nested typess
    public class Employee
    {
        //Fields 
        // Aceess modifier >> public, private, protected, internal, protected internal

        public string fName;
        public string lName;
        public double wage;
        public double loggedHours;
        //constant 
        public const double TAX = 0.03;

    }
}
