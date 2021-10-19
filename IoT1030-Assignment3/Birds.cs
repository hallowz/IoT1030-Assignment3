using System;

using A3.Eggs;
namespace A3.Birds
{
	abstract class Bird
	{
		public static Random Rand = new Random(1);
		public virtual Egg[] LayEggs(int numEggs)
		{
			Console.Error.WriteLine("Bird.LayEggs should not be called!");
			return new Egg[0];
		}
		protected Egg[] GetEggs(int numEggs, double minSize, double maxSize, double brokenChance, Egg.Colors color)
        {
			Egg[] eggs = new Egg[numEggs];
			for (int i = 0; i < numEggs; i++)
			{
				if (Rand.NextDouble() * 100 <= brokenChance) //.NextDouble() returns between 0 and 1, multiply that by 100 and return broken egg if it's below the chance
					eggs[i] = new BrokenEgg((Rand.NextDouble() * (maxSize - minSize)) + minSize, color);
				else
					eggs[i] = new Egg((Rand.NextDouble() * (maxSize - minSize)) + minSize, color);
			}
			return eggs;
		}
	}

	class Chicken : Bird
	{
		public override Egg[] LayEggs(int numEggs)
        {
			return GetEggs(numEggs, 2.0, 4.0, 25.0, Egg.Colors.brown);
			/*
			Egg[] eggs = new Egg[numEggs];
			for (int i = 0; i < numEggs; i++)
			{
				if (Rand.Next(1, 4) == 1)
					eggs[i] = new BrokenEgg((Rand.NextDouble() * 2.0) + 2.0, Egg.Colors.brown);
				else
					eggs[i] = new Egg((Rand.NextDouble() * 2.0) + 2.0, Egg.Colors.brown);
			}
			return eggs;
			*/
        }
	}

	class Ostrich : Bird 
	{
		public override Egg[] LayEggs(int numEggs)
		{
			return GetEggs(numEggs, 10.0, 15.0, 45.0, Egg.Colors.speckled);
			/*
			Egg[] eggs = new Egg[numEggs];
			for (int i = 0; i < numEggs; i++)
			{
				if (Rand.Next(1, 20) < 10)
					eggs[i] = new BrokenEgg((Rand.NextDouble() * 5.0) + 10.0, Egg.Colors.speckled);
                else
					eggs[i] = new Egg((Rand.NextDouble() * 5.0) + 10.0, Egg.Colors.speckled);
			}
			return eggs;
			*/
		}
	}
}
