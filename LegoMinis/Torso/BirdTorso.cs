using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinis.Torso
{
    class BirdTorso : ReptilianTorso
    {
				public bool CanFly {get;set;}
        
        public void Fly()
			  { 
						if (CanFly)
						{
							Console.WriteLine("I believe I can fly...");
					  }
						else
						{
								Console.WriteLine("Yo soy flightless");
					  }
        }
    }
}
