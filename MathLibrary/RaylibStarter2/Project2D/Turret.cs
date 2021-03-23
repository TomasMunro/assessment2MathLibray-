using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib;
using static Raylib.Raylib;
using MathClasses;

namespace Project2D
{
	class Turret : GameObject
	{
		public Turret(string fileName) : base(fileName)
		{
			m_mLocalTransformation.m7 = 50;
			m_mLocalTransformation.m8 = 50;



		}

		public override void Update(float fDeltaTime)
		{
			float fRotation = 0.0f;

			if (IsKeyDown(KeyboardKey.KEY_A))
			{
				fRotation -= 1.0f * fDeltaTime;
			}
			if (IsKeyDown(KeyboardKey.KEY_D))
			{
				fRotation += 1.0f * fDeltaTime;	
			}
			
			Matrix3 rotation = new Matrix3();
			rotation.SetRotateZ(fRotation);
			m_mLocalTransformation = m_mLocalTransformation * rotation;
			////add velocity to our transforms
			//Matrix3 translation = new Matrix3();
			//translation.SetTranslation(m_v2Velocity * fDeltaTime);

			//m_mLocalTransformation = m_mLocalTransformation * translation;



			base.Update(fDeltaTime);

		}
	}
}
