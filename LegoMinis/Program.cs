using LegoMinis.Head;
using LegoMinis.Torso;
using LegoMinis.Legs;
using System;

namespace LegoMinis
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new NathanHead();
						var reptileBody = new ReptilianTorso();
            var babyLegs = new BabyLegs();
            babyLegs.Length = 19;
            babyLegs.MainColor = "purp";
            babyLegs.ShoeColor = "deep satin";
						reptileBody.Color = "Brown";

				    var figure = new Minifigure("Todd", head, reptileBody, babyLegs);

						figure.Greet();

            var head2 = new NathanHead();
            var birdBody = new ReptilianTorso();
            birdBody.Color = "various";
            var manLegs = new BabyLegs();
            babyLegs.Length = 36;
            babyLegs.MainColor = "Gold";
            babyLegs.ShoeColor = "Golder";

            reptileBody.Color = "Brown";

            var figure2 = new Minifigure("Stefan", head, birdBody, manLegs);

            figure2.Greet();
            figure.Karate(figure2);
            figure.TakeABreak();
            figure2.TakeABreak();

      Console.ReadLine();
        }
    }
}
