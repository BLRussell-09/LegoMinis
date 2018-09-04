using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinis.Head
{
    class BaldHead : HeadBase
    {
			public override bool HasHair { get { return false; } }
      public int SmoothnessLvl { get; set;}

			public override void Talk()
			{
				Console.WriteLine("Hello I'm Human Person");
			}

			public override void Eat()
			{
        Console.WriteLine("*Eats a burrito*");
		  }
		}
}
