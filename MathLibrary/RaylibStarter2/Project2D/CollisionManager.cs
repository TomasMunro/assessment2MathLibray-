using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2D
{
	class CollisionManager
	{
		private static List<GameObject> m_ObjectList = new List<GameObject>();
		public static void AddObject(GameObject obj)
		{
			m_ObjectList.Add(obj);
		}
		public static void CheckCollision()
		{
			//Test collision here
			foreach (GameObject obj1 in m_ObjectList)
			{

				foreach (GameObject obj2 in m_ObjectList)
				{
					if (obj1 == obj2)
						continue;
					//test collision 

					//VECTOR2 DIFFERENCE = OBJ1.position - obj2 .position  
					//if object(A) x.max larger than object(B) x.min && object(A) y.Max is larger that object(B) y min 
					//public Vector2 m_v2centre 


					//if colliding , resolve collision

					obj1.OnCollision(obj2);
				
				
				}
			}
		}

	}
}
