using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
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

		public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
		{
			Vector3 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;
			result.z = lhs.z + rhs.z;
			return result;

		}

		public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
		{
			Vector3 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;
			result.z = lhs.z - rhs.z;
			return result;

		}
		public static Vector3 operator *(Vector3 lhs, float rhs)
		{
			Vector3 result;
			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;
			result.z = lhs.z * rhs;
			return result;

		}
		public static Vector3 operator *(float lhs, Vector3 rhs)
		{
			Vector3 result;
			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;
			result.z = lhs * rhs.z;
			return result;

		}
		public float Magnitude()
		{
			//c= sqrt(a^2 + b^2)
			return (float)Math.Sqrt((x * x) + (y * y) + (z * z));

		}
		public void Normalise()
		{
			float magnitude = Magnitude();
			if (magnitude != 0)
			{
				x /= magnitude;
				y /= magnitude;
				z /= magnitude;
			}
		}
		//Dot finds the ratio between two points
		public float Dot(Vector3 rhs)
		{
			return (x * rhs.x) + (y * rhs.y) + (z * rhs.z);

		}
		//this finds the the right angles of a vector
		public Vector3 Cross(Vector3 rhs)
		{
			Vector3 result;
			result.x = (y * rhs.z) - (z * rhs.y);
			result.y = (z * rhs.x) - (x * rhs.z);
			result.z = (x * rhs.y) - (y * rhs.x);
			return result;


		}





	}
}
