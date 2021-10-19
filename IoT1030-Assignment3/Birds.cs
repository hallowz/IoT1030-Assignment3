using System;

using A3.Eggs;
namespace A3.Birds
{
	class Bird
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
		// TODO: Implement this class
	}

	class Ostrich : Bird 
	{
		// TODO: Implement this class
	}
}
