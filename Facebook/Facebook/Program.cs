using System;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            User myUsr = new User("vusal", "nasirli", "nvusal.606@gmail.com,", new DateTime(2001), true);
            Console.WriteLine(myUsr);
        }
    }
}
