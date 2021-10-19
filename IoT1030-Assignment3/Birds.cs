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
	}

	class Chicken : Bird
	{
		public override Egg[] LayEggs(int numEggs)
        {
			Random rand = new Random(1);
			Egg[] eggs = new Egg[numEggs];
			for(int i = 0; i < numEggs; i++)
				eggs[i] = new Egg((rand.NextDouble() * 2.0) + 2.0, Egg.Colors.brown);
			return eggs;
        }
	}

	class Ostrich : Bird 
	{
		public override Egg[] LayEggs(int numEggs)
		{
			Random rand = new Random(1);
			Egg[] eggs = new Egg[numEggs];
			for (int i = 0; i < numEggs; i++)
				eggs[i] = new Egg((rand.NextDouble() * 5.0) + 10.0, Egg.Colors.speckled);
			return eggs;
		}
	}
}
