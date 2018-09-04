using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinis.Head
{
	class NathanHead : HeadBase
    {

// Props
			public override bool HasHair { get { return true; } }
			public string HairColor { get { return "Salt N Peppered";} }
			public string Texture { get; set;}

// Methods

			public override void Eat() 
			{ 
			   Console.WriteLine("I never eat");
			}
		}
}
