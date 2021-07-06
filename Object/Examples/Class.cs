using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Examples
{
	public class Class
	{
		public void Run()
		{
			Car car = new Car();
			car.Size = "sedan";
			car.Color = "white";

			Console.WriteLine($"your car, {car.getColor()} {car.getSize()} has");

			car.Engine_on();
			car.Go();
			car.Back();
			car.Left();
			car.Right();
			car.Engine_off();
		}
	}

	public class Car
	{
		#region props and get/setter
		private string size;
		private string color;

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

		public void setSize(string size)
		{
			this.size = size;
		}

		public string getSize()
		{
			return size;
		}

		public void setColor(string color)
		{
			this.color = color;
		}

		public string getColor()
		{
			return color;
		}
		#endregion

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
		#endregion
	}
}
