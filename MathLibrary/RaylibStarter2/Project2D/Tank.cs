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
	class Tank : GameObject
	{
		protected Turret TankTurret = null;
		private Vector2 m_v2Velocity;
		private float m_fSpeed = 88.0f;
		//public float dampening = 5f; 
		

		public Tank(string fileName):base(fileName)
		{
			TankTurret = new Turret("../Images/Turret.png");

			TankTurret.SetParent(this);
			TankTurret.SetPosition(new Vector2(m_mLocalTransformation.m7, m_mLocalTransformation.m8));
			m_mLocalTransformation.m7 = 50;
			m_mLocalTransformation.m8 = 50;
			m_v2Velocity.x = 0;
			m_v2Velocity.y = 0;


		}
		public override void Update(float fDeltaTime)
		{
			float fRotation = 0.0f;
			if (IsKeyDown(KeyboardKey.KEY_DOWN))
			{
				m_v2Velocity.y += m_fSpeed * fDeltaTime;
			}
			if (IsKeyDown(KeyboardKey.KEY_UP))
			{
				m_v2Velocity.y -= m_fSpeed * fDeltaTime;
			}
			if (IsKeyDown(KeyboardKey.KEY_LEFT))
			{
				fRotation -= 1.0f * fDeltaTime;
			}
			if (IsKeyDown(KeyboardKey.KEY_RIGHT))
			{
				fRotation += 1.0f * fDeltaTime;
			}
			//add velocity to our transforms
			Matrix3 translation = new Matrix3();
			translation.SetTranslation(m_v2Velocity * fDeltaTime);
			//translation.SetTranslation(m_v2Velocity / dampening);
			m_mLocalTransformation = m_mLocalTransformation * translation;
			Matrix3 rotation = new Matrix3();
			rotation.SetRotateZ(fRotation);
			m_mLocalTransformation= m_mLocalTransformation * rotation;

			base.Update(fDeltaTime);


		

		}
			
		

	}
}
