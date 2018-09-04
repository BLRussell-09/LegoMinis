using LegoMinis.Head;
using System;

namespace LegoMinis
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new NathanHead();

				    var figure = new Minifigure(head);
						figure.DoStuff();

						Console.ReadLine();
        }
    }
}
