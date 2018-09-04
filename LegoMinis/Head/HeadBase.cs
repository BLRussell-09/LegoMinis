using System;

namespace LegoMinis.Head
{
	abstract class HeadBase //Abstract class has no default implementation
		{
       public abstract bool HasHair {get; } // All classes with this name base must have this prop with a publicly gettable value

		   public virtual void Talk()
			 {
          Console.WriteLine("I am Professor Genius");
       }

			 public abstract void Eat();
		}
}
