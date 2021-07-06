using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Examples
{
	public class Inheritance
	{
		public static void Run()
		{
			GasolineCar gcar = new GasolineCar();
			gcar.Color = "black";
			gcar.Size = "SUV";

			ElectronicCar ecar = new ElectronicCar();
			ecar.Color = "green";
			ecar.Size = "small";

			Console.WriteLine($"your {gcar.Color} {gcar.Size} has");
			gcar.Go();
			gcar.InputGas();

			Console.WriteLine($"your {ecar.Color} {ecar.Size} has");
			ecar.Back();
			ecar.InputGas();
		}
	}

	class Car2
	{
		public string Size
		{
			get;
			set;
		}

		public string Color
		{
			get;
			set;
		}

		#region methods
		public void Engine_on()
		{
			Console.WriteLine("start the engine");
		}

		public void Engine_off()
		{
			Console.WriteLine("stop the engine");
		}

		public void Go()
		{
			Console.WriteLine("go forward");
		}

		public void Back()
		{
			Console.WriteLine("go backwards");
		}

		public void Left()
		{
			Console.WriteLine("turn left");
		}

		public void Right()
		{
			Console.WriteLine("turn right");
		}

		public virtual void InputGas()
		{
			Console.WriteLine("Input Gas");
		}
		#endregion
	}

	class GasolineCar : Car2
	{
		public override void InputGas()
		{
			Console.WriteLine("input gasoline");
		}
	}
	class ElectronicCar : Car2
	{
		public override void InputGas()
		{
			Console.WriteLine("input electrons");
		}
	}
}
