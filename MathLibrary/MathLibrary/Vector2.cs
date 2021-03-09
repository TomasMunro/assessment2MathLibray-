using System;

namespace MathLibrary
{
	public struct Vector2
	{
		public float x;
		public float y;
		public Vector2(float x,float y)
		{
			this.x = x;
			this.y = y;
		}
		//operator overloading
		public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;
			return result;
		}
		//v-v
		public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;
			return result;

		}
		//v * f
		public static Vector2 operator *(Vector2 lhs, float rhs)
		{
			Vector2 result;
			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;
			return result;
		
		}



	}
	public struct Vector3
	{
		public float x;
		public float y;
		public float z;

		public Vector3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
	}
	


}
