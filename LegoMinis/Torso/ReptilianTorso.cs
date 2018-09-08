using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinis.Torso
{
	class ReptilianTorso : Torsos
    {
				public string ScaleShape {get;set;}

				public void Dance()
				{
						Console.WriteLine("*Breakdances vigorously on some freak bitches*");
			  }

				public void Twist()
				{
						Console.WriteLine("A little bit louder now!");
			  }
    }
}
