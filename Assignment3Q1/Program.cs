using System;

namespace Assignment3Q1
{
	class Program
	{
		static void Main(string[] args)
		{
			Vector2D vector1 = new Vector2D();
			vector1.SetX(2);
			vector1.SetY(5);

			Vector2D vector2 = new Vector2D();
			vector2.SetX(3);
			vector2.SetY(4);

			Vector2D final = vector1 * vector2;

			Console.WriteLine("Final Vector X: {0}", final.GetX());
			Console.WriteLine("Final Vector Y: {0}", final.GetY());
			Console.ReadLine();
		}
	}

	public class Vector2D
	{
		private int _x;
		private int _y;
		public void SetX(int x)
		{
			_x = x;
		}

		public void SetY(int y)
		{
			_y = y;
		}

		public int GetX()
		{
			return _x;
		}

		public int GetY()
		{
			return _y;
		}

		public static Vector2D operator *(Vector2D A, Vector2D B)
		{
			Vector2D result = new Vector2D();
			result.SetX(A._x * B._x);
			result.SetY(A._y * B._y);
			return result;
		}
	}
}
