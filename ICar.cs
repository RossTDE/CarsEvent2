using System;
using GameCycle;

namespace Cars
{
	public interface ICar
	{
		string Name { get; set; }
		int min_speed { get; } //диапазон скорости
		int max_speed { get; }
		int coord { get; set; }
		static int place = 1; //счетчик рейтинга

		int Move();
		void Finish();
		void Coords();
	}

	public class F1 : ICar
    {
		public string Name { get; set; }
		public int min_speed { get; } = 15;
		public int max_speed { get; } = 25;
		public int coord { get; set; } = 0;

		public F1(string name) {
			Name = name; 
		}

		public int Move()
		{
			Random rand = new Random();
			coord += rand.Next(min_speed, max_speed); //постоянно меняется типо как в жизни

			return coord;
        }

		public void Finish()
		{
			Console.WriteLine($"{Name} had finished on {ICar.place} place with {coord} coordinate");
			ICar.place++;
		}

		public void Coords() => Console.WriteLine($"{Name} is on {coord} coordinate");
	}

	public class F2 : ICar
	{
		public string Name { get; set; }
		public int min_speed { get; } = 10;
		public int max_speed { get; } = 20;
		public int coord { get; set; } = 0;

		public F2(string name)
		{
			Name = name;
		}

		public int Move()
		{
			Random rand = new Random();
			coord += rand.Next(min_speed, max_speed);

			return coord;
		}

		public void Finish()
		{
			Console.WriteLine($"{Name} had finished on {ICar.place} place with {coord} coordinate");
			ICar.place++;
		}

		public void Coords() => Console.WriteLine($"{Name} is on {coord} coordinate");
	}

	public class F3 : ICar
	{
		public string Name { get; set; }
		public int min_speed { get; } = 8;
		public int max_speed { get; } = 15;
		public int coord { get; set; } = 0;

		public F3(string name)
		{
			Name = name;
		}

		public int Move()
		{
			Random rand = new Random();
			coord += rand.Next(min_speed, max_speed);

			return coord;
		}

		public void Finish()
		{
			Console.WriteLine($"{Name} had finished on {ICar.place} place with {coord} coordinate");
			ICar.place++;
		}

		public void Coords() => Console.WriteLine($"{Name} is on {coord} coordinate");
	}


}

