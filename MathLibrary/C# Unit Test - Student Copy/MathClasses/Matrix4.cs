using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public struct Matrix4
    {
		
		//public float[] m;
		public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;

        
		public Matrix4(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9, float m10, float m11, float m12, float m13, float m14, float m15, float m16)
		{
			//m = new float[16];
			this.m1 = m1;
			this.m2 = m2;
			this.m3 = m3;
			this.m4 = m4;
			this.m5 = m5;
			this.m6 = m6;
			this.m7 = m7;
			this.m8 = m8;
			this.m9 = m9;
			this.m10 = m10;
			this.m11 = m11;
			this.m12 = m12;
			this.m13 = m13;
			this.m14 = m14;
			this.m15 = m15;
			this.m16 = m16;


		}

		public static Vector4 operator *(Matrix4 lhs, Vector4 rhs)
		{
			Vector4 result;
			result.x = (lhs.m1 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m9 * rhs.z)+ (lhs.m13 * rhs.w);
			result.y = (lhs.m2 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m10 * rhs.z)+ (lhs.m14 * rhs.w);
			result.z = (lhs.m3 * rhs.x) + (lhs.m7 * rhs.y) + (lhs.m11 * rhs.z)+ (lhs.m15 * rhs.w);
			result.w = (lhs.m4 * rhs.w) + (lhs.m8 * rhs.w) + (lhs.m12 * rhs.w) + (lhs.m16 * rhs.w);
			return result;

		}
		public static Matrix4 operator *(Matrix4 lhs, Matrix4 rhs)
		{

			Matrix4 result = new Matrix4();
		//                       L          R            L          R            L          R             L          R
			result.m1 = (lhs.m1 * rhs.m1) + (lhs.m5 * rhs.m2) + (lhs.m9  * rhs.m3) + (lhs.m13 * rhs.m4);
			result.m2 = (lhs.m2 * rhs.m1) + (lhs.m6 * rhs.m2) + (lhs.m10  * rhs.m3) + (lhs.m14 * rhs.m4);
			result.m3 = (lhs.m3 * rhs.m1) + (lhs.m7 * rhs.m2) + (lhs.m11 * rhs.m3) + (lhs.m15 * rhs.m4);
			result.m4 = (lhs.m4 * rhs.m1) + (lhs.m8 * rhs.m2) + (lhs.m12 * rhs.m3) + (lhs.m16 * rhs.m4);

			result.m5 = (lhs.m1 * rhs.m5) + (lhs.m5 * rhs.m6) + (lhs.m9   * rhs.m7) + (lhs.m13 * rhs.m8);
			result.m6 = (lhs.m2 * rhs.m5) + (lhs.m6 * rhs.m6) + (lhs.m10   * rhs.m7) + (lhs.m14 * rhs.m8);
			result.m7 = (lhs.m3 * rhs.m5) + (lhs.m7 * rhs.m6) + (lhs.m11  * rhs.m7) + (lhs.m15 * rhs.m8);
			result.m8 = (lhs.m4 * rhs.m5) + (lhs.m8 * rhs.m6) + (lhs.m12  * rhs.m7) + (lhs.m16 * rhs.m8);

			result.m9 = (lhs.m1 * rhs.m9) + (lhs.m5 * rhs.m10) + (lhs.m9   * rhs.m11) + (lhs.m13 * rhs.m12);
			result.m10 = (lhs.m2 * rhs.m9) + (lhs.m6 * rhs.m10) + (lhs.m10   * rhs.m11) + (lhs.m14 * rhs.m12);
			result.m11 = (lhs.m3 * rhs.m9) + (lhs.m7 * rhs.m10) + (lhs.m11 * rhs.m11) + (lhs.m15 * rhs.m12);
			result.m12 = (lhs.m4 * rhs.m9) + (lhs.m8 * rhs.m10) + (lhs.m12 * rhs.m11) + (lhs.m16 * rhs.m12);

			result.m13 = (lhs.m1 * rhs.m13) + (lhs.m5 * rhs.m14) + (lhs.m9  * rhs.m15) + (lhs.m13 * rhs.m16);
			result.m14 = (lhs.m2 * rhs.m13) + (lhs.m6 * rhs.m14) + (lhs.m10  * rhs.m15) + (lhs.m14 * rhs.m16);
			result.m15 = (lhs.m3 * rhs.m13) + (lhs.m7 * rhs.m14) + (lhs.m11 * rhs.m15) + (lhs.m15 * rhs.m16);
			result.m16 = (lhs.m4 * rhs.m13) + (lhs.m8 * rhs.m14) + (lhs.m12 * rhs.m15) + (lhs.m16 * rhs.m16);

			return result;


		}
		//set rot x y z 
		public void SetRotateX(float fRadians)
		{
			identity();
			m6 = (float)Math.Cos(fRadians);
			m7 = (float)Math.Sin(fRadians);
			m10 = (float)-Math.Sin(fRadians); 
			m11 = (float)Math.Cos(fRadians);

		}
		public void SetRotateY(float fRadians)
		{
			identity();
			m1 = (float)Math.Cos(fRadians);
			m3 = (float)-Math.Sin(fRadians);
			m9 = (float)Math.Sin(fRadians);
			m11 = (float)Math.Cos(fRadians);


		}
		public void SetRotateZ(float fRadians)
		{
			identity();
			m1 = (float)Math.Cos(fRadians);
			m2 = (float)Math.Sin(fRadians);
			m5 = (float)-Math.Sin(fRadians);
			m6 = (float)Math.Cos(fRadians);


		}




		//Extra helpful functions

		public void SetTranslation(Vector3 pos)
		{
			identity();
			m13 = pos.x;
			m14 = pos.y;
			m15 = pos.z;

		}

		public void SetScale(float x, float y,float z)
		{
			identity();
			m1 = x;
			m6 = y;
			m11 = z;

		}

		public void SetScale(Vector3 scale)
		{
			identity();
			m1 = scale.x;
			m6 = scale.y;
			m11 = scale.z;
		}
		public void identity()
		{
			
			m1 = 1;
			m2 = 0;
			m3 = 0;
			m4 = 0;
			m5 = 0;
			m6 = 1;
			m7 = 0;
			m8 = 0;
			m9 = 0;
			m10 = 0;
			m11 = 1;
			m12 = 0;
			m13 = 0;
			m14 = 0;
			m15 = 0;
			m16 = 1;


		}



	}
}
