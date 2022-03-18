using System;
using Cars;
using System.Collections.Generic;
using System.Threading;
using FUNS;

namespace GameCycle
{

	public class Game
	{
		private delegate void Message();
		private event Message Display; //событие

		private List<ICar> CarsList = new List<ICar>(); //список учавствующих машин

		private const int finish = 100; //расстояние до финиша(магические числа низя)

		public Game(params ICar[] carsArray)
		{
			foreach(ICar car in carsArray) //формирует список
            {
				CarsList.Add(car); 
            }
		}

		public void Start() //Главный цикл игры
        {
			foreach (ICar car in CarsList) //каждая машина проезжает свой путь за секунду
			{
				Display += car.Coords;
			}

			while (CarsList.Count > 0)
            {
				List<ICar> CarsToDelete = new List<ICar>(); //это пришлось сделать для того,
															//чтобы удалять машину из списка после цикла

				foreach (ICar car in CarsList) //каждая машина проезжает свой путь за секунду
				{
					if (car.Move() > finish)
					{
						Display += car.Finish;
						Display -= car.Coords;
						CarsToDelete.Add(car);
					}
				}
				Display?.Invoke();

				foreach (ICar car in CarsToDelete)
                {
					Display -= car.Finish;
					CarsList.Remove(car);
                }
				CarsToDelete.Clear();

				

				for (int i = 0; i < 3; i++) //просто красивое ожидание
				{
					Thread.Sleep(500);
					Console.Write(". ");
					Thread.Sleep(500);
				}
				Console.WriteLine();
			}
        }
	}
}

