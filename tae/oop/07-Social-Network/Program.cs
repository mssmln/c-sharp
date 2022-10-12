// You are making a social network application and want to add post creation functionality.
// As a user creates a post, the text "New post" should be automatically outputted so that then the user can add the text he/she wants to share.
// The program you are given declares a Post class with a text private field, and the ShowPost() method which outputs the content.
// Complete the class with
// a constructor, which outputs "New post" as called,
// Text property, which will allow you to get and set the value of the text field.

using System;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();
            Post post = new Post();
            post.Text = postText;
            post.ShowPost();
        }
    }
    class Post
    {
        private string text;
        public Post()
        {
            Console.WriteLine("New post");
        }
        public void ShowPost()
        {
            Console.WriteLine(text);
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}