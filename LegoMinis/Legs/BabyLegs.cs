using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinis.Legs
{
  class BabyLegs : Leg
  {
    public BabyLegs()
    {
        Length = 10;
        HasPants = false;
    }

    public void Walk()
    {
      if (Length > 18)
        Console.WriteLine($"The {MainColor} baby legs wobble-strutted around the playpen in {ShoeColor} shoes.");
      else
        Console.WriteLine($"The {MainColor} baby legs crawled around the playpen");
    }

    public void Kick(Minifigure minifigure)
    {
      Console.WriteLine($"Baby legs kicked {minifigure.Name}, the {minifigure.Description}.");
    }
  }

  

    class Leg 
    { 
        public int Length { get;set; } = 34;
        public bool HasPants { get;set; } = true;
        public string ShoeColor { get;set; }
        public string MainColor { get;set; }
        public void Walk()
        {
            Console.WriteLine($"The {MainColor} baby legs walked around the office");
        }

        public void Kick(Minifigure minifigure)
        { 
           Console.WriteLine($"Baby legs kicked {minifigure.Name}, the {minifigure.Description}.");
        }
    }
}
