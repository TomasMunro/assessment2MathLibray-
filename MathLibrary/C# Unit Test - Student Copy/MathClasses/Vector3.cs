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
		//if you want to find the radius betweent two points
		//normalize setting both vectors to 1
		//Dot(find the ratio) between two points
		//find out which direction= you need to create a right angle
		//you do that by picking a point lets say A swapping the vector values eg)y=x,x=y
		//now we have a new point C which is right angle to A
		//we then perfor a Dot function Betweeen point C and B if result is positive the quickest direction between a-b is positive 
		//

		//-----------------------------------------------------------------------------------
		//this finds the the right angles of a vector(facing forward whats right (angle) or right)

		public Vector3 Cross(Vector3 rhs)
		{
			Vector3 result;
			result.x = (y * rhs.z) - (z * rhs.y);
			result.y = (z * rhs.x) - (x * rhs.z);
			result.z = (x * rhs.y) - (y * rhs.x);
			return result;

		}
		//if you want to find what 





	}
}
