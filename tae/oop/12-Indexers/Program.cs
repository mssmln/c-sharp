// An indexer allows objects to be indexed like an array.
// As discussed earlier, a string variable is actually an object of the String class. Further, the String class is actually an array of Char objects. In this way, the string class implements an indexer so we can access any character (Char object) by its index
// Arrays use integer indexes, but indexers can use any type of index, such as strings, characters, etc.

// Declaration of an indexer is to some extent similar to a property. The difference is that indexer accessors require an index.
// Like a property, you use get and set accessors for defining an indexer. However, where properties return or set a specific data member, indexers return or set a particular value from the object instance.
// Indexers are defined with the this keyword.
// You typically use an indexer if the class represents a list, collection, or array of objects.

// The music app you enjoy allows you to choose 5 music genres to follow.
// The program you are given takes 5 music genres as input and stores them in the MusicGenres object as an array.
// Fix the program by declaring an indexer inside the MusicGenres class so that the given outputs work correctly.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Now, when we declare an object of class MusicGenres, we use an index to refer to specific objects like the elements of an array
            MusicGenres genres = new MusicGenres();

            int count = 0;
            while (count < 5)
            {
                genres[count] = Console.ReadLine();
                count++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Following: " + genres[i]);
            }
        }
    }
    class MusicGenres
    {
        private string[] genres = new string[5];

        // As you can see, the indexer definition includes the this keyword and an index, which is used to get and set the appropriate value.
        public string this[int index]
        {
            get
            {
                return genres[index];
            }
            set
            {
                genres[index] = value;
            }
        }
    }
}