// As we have seen in the previous lessons, it is a good practice to encapsulate members of a class and provide access to them only through public methods.
// A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field.Properties can be used as if they are public data members, but they actually include special methods called accessors.
// The accessor of a property contains the executable statements that help in getting (reading or computing) or setting(writing) a corresponding field. Accessor declarations can include a get accessor, a set accessor, or both.

// value is a special keyword, which represents the value we assign to a property using the set accessor.
// The name of the property can be anything you want, but coding conventions dictate properties have the same name as the private field with a capital letter.

// Any accessor of a property can be omitted.
// For example, omitting set creates a property that is read-only
// A property can also be private, so it can be called only from within the class.

// With properties you have the option to control the logic of accessing the variable.
// When you do not need any custom logic, C# provides a fast and effective mechanism for declaring private members through their properties.

// For example, to create a private member that can only be accessed through the Name property's get and set accessors, use the following syntax:
// public string Name { get; set; }
// As you can see, you do not need to declare the private field name separately - it is created by the property automatically. Name is called an auto-implemented property.


// Create a get property to access the corresponding class member and also fix the output.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card();
            Console.WriteLine(card1.AccountNum);
        }
    }
    class Card
    {
        private string accountNum = "0011592048120";
        public string AccountNum
        {
            get { return accountNum; }
            // set { name = value; }
        }
    }
}