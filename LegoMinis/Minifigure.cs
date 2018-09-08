using LegoMinis.Head;
using LegoMinis.Torso;
using LegoMinis.Legs;
using System;

namespace LegoMinis
{
    class Minifigure
    {
			private readonly HeadBase _head;
			private readonly Torsos _torso;
      private readonly Leg _leg;

    public string Name { get; }
      public string Description 
      { 
          get 
          {
              return $"{(_head.HasHair ? "Hairy" : "Bald")} {_torso.Color} {_torso.NumberOfArms} armed thing";
          }
      }

    public Minifigure(string name, HeadBase head, Torsos torso, Leg leg)
			{
				_head = head;
				_torso = torso;
        _leg = leg;
    }

       public void Greet()
			 {
          _head.Talk();
          _torso.Wave();
       }

       public void Karate(Minifigure target)
       {
          _leg.Kick(target);
       }

			 public void TakeABreak()
			 { 

					switch(_torso)
					{ 
							case BirdTorso bird :
									bird.Fly();
									bird.Dance();
									bird.Fly();
									break;
							case ReptilianTorso reptile :
									reptile.Dance();
									break;
							case Torsos boringTorso :
									Console.WriteLine($"The boring torso was {boringTorso.Color} and has {boringTorso.NumberOfArms} arms;");
									break;
					}
			 }

    }
}
