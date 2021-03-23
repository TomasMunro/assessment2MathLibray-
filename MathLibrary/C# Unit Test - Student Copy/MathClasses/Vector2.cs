using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
	public struct Vector2
	{

		public float x;
		public float y;
	

		public Vector2(float x, float y)
		{
			this.x = x;
			this.y = y;
			
		}

		public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;
			
			return result;

		}

		public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;
			
			return result;

		}
		public static Vector2 operator *(Vector2 lhs, float rhs)
		{
			Vector2 result;
			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;
			
			return result;

		}
		public static Vector2 operator *(float lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;
			
			return result;

		}
		public float Magnitude()
		{
			//c= sqrt(a^2 + b^2)
			return (float)Math.Sqrt((x * x) + (y * y) );

		}
		public void Normalize()
		{
			float magnitude = Magnitude();
			if (magnitude != 0)
			{
				x /= magnitude;
				y /= magnitude;
				
			}
		}
		//Dot finds the ratio between two points
		public float Dot(Vector3 rhs)
		{
			return (x * rhs.x) + (y * rhs.y);

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

		
	}
}
