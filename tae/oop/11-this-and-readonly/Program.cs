// The this keyword is used inside the class and refers to the current instance of the class, meaning it refers to the current object.
// One of the common uses of this is to distinguish class members from other data, such as local or formal parameters of a method
// Another common use of this is for passing the current instance to a method as parameter: ShowPersonInfo(this);

// The readonly modifier prevents a member of a class from being modified after construction. It means that the field declared as readonly can be modified only when you declare it or from within a constructor.
// If we try to modify the name field anywhere else, we will get an error.
// There are three major differences between readonly and const fields.
// First, a constant field must be initialized when it is declared, whereas a readonly field can be declared without initialization
// Second, a readonly field value can be changed in a constructor, but a constant value cannot.
// Third, the readonly field can be assigned a value that is a result of a calculation, but constants cannot


// Complete the Avg class by creating the constructor, where the 2 parameters will be assigned to members of the class.
using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Avg avg = new Avg(num1, num2);
            Console.WriteLine(avg.GetAvg());
        }
    }
    class Avg
    {
        double num1;
        double num2;
        public Avg(double n1, double n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }
        public double GetAvg()
        {
            return (num1 + num2) / 2;
        }
    }
}