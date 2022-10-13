// Class members(variables, properties, methods) can also be declared as static. This makes those members belong to the class itself, instead of belonging to individual objects. No matter how many objects of the class are created, there is only one copy of the static member.
// Because of their global nature, static members can be accessed directly using the class name without an object.
// You must access static members using the class name. If you try to access them via an object of that class, you will generate an error.

// Static methods can access only static members.
// The Main method is static, as it is the starting point of any program. Therefore any method called directly from Main had to be static.

// Constant members are static by definition.
// Constructors can be declared static to initialize static members of the class.
// The static constructor is automatically called once when we access a static member of the class.


// Complete the Department class to have 1 static member depCount with an initial value of 2 for the number of departments and the constructor that will count it and output corresponding message
using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDeps = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (count < numOfDeps)
            {
                string depName = Console.ReadLine();
                Department dep = new Department(depName);
                count++;
            }
            Console.WriteLine("Number of departments: " + Department.depCount);
        }
    }
    class Department
    {
        public string depName;
        public static int depCount = 2;
        public Department(string name)
        {
            Console.WriteLine("Department opened: " + name);
            this.depName = name;
            depCount++;
        }
    }
}