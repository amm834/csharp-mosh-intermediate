using System;

namespace Indexers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Mg Mg";
            Console.WriteLine(cookie["name"]);
        }
    }
}