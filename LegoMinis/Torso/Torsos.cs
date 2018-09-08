using System;

namespace LegoMinis.Torso
{
	class Torsos
		{ 
				public string Color {get;set;}
				public int NumberOfArms {get;set;}
				public bool HasClothes {get;set;}

        public void Wave() 
        { 
          if (NumberOfArms > 1)
          {
              Console.WriteLine("*Waves");
          }
        }

		}
}
