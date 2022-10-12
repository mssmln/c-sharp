// A class constructor is a special member method of a class that is executed whenever a new object of that class is created.
// A constructor has exactly the same name as its class, is public, and does not have any return type.
// Constructors can be overloaded like any method by using different numbers of parameters.

// Your graphic application needs to report that a new project has been created successfully once the "Create" button has been pressed.
// Complete the given class by adding a constructor that will show message "Project created" once the operation is done.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Project project = new Project();
        }
    }
    class Project
    {
        public Project()
        {
            Console.Write("Project created");
        }
    }
}