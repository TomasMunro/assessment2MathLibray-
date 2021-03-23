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
	class GameObject
	{
		//Parent(GameObject)
		protected GameObject m_oParent = null;
		//List of children(GameObject)
		protected List<GameObject> m_oChildren = new List<GameObject>();
		//Local transform(matrix)
		protected Matrix3 m_mLocalTransformation;
		//Global transform(matrix)
		protected Matrix3 m_mGlobalTransform;
		//Image and Texture for drawing
		protected Image m_Image;
		protected Texture2D m_tTexture;
		

		//Radius for collision
		public GameObject(string fileName)
		{
			//load image and convert to texture
			m_Image = LoadImage(fileName);
			m_tTexture = LoadTextureFromImage(m_Image);
			m_mLocalTransformation.Identity();
			m_mLocalTransformation.Identity();

			//starting pos 
			//m_mLocalTransformation.m7 = 100;
			//m_mLocalTransformation.m8 = 200;
			

			CollisionManager.AddObject(this);


		}
		///-------------Functions----------------
		//SetParent
		public void SetParent(GameObject parent)
		{
			if (m_oParent != null)
			
			m_oParent.m_oChildren.Remove(this);
			//set new parent
			m_oParent = parent;
			//add to new parent
			if (m_oParent != null)
			
				m_oParent.m_oChildren.Add(this);
			
		}
		//GetParent
		public void GetParent()
		{
		}

		//AddChild
		public void AddChild()
		{
		}

		//RemoveChild
		public void RemoveChild()
		{
		}
		//SetPosition
		public void SetPosition(Vector2 position)
		{
			m_mLocalTransformation.SetTranslation(position);

			
		}
		//GetPosition
		public Vector2 GetPosition()
		{
			Vector2 newPos = new Vector2(m_mLocalTransformation.m7, m_mLocalTransformation.m6);
			return newPos;
			
		}
		//SetRotation
		public void SetRotation(float radiant)
		{
			m_mLocalTransformation.SetRotateZ(radiant);

		}
		//GetRotation
		public void GetRotation()
		{
		}
		//SetScale
		public void SetScale()
		{
		}
		//GetScale
		public void GetScale()
		{
		}
		//Update
		public virtual void Update( float deltaTime)
		{
			
			
			foreach (GameObject child in m_oChildren)
			{
				child.Update(deltaTime);
			}
			


			

		}
		//UpdateTransforms
		public void UpdateTransforms()
		{
			if (m_oParent != null&& m_oChildren !=null)
				m_mGlobalTransform = m_oParent.m_mGlobalTransform* m_mLocalTransformation;
			else
				m_mGlobalTransform = m_mLocalTransformation;

			foreach (GameObject child in m_oChildren)
			{
				child.UpdateTransforms();
			}
		}
		//Draw
		public void Draw()
		{

			Renderer.DrawTexture(m_tTexture, m_mGlobalTransform, RLColor.WHITE.ToColor());
			foreach (GameObject child in m_oChildren)
			{
				child.Draw();
			}

		}
		//OnCollision
		public void OnCollision()
		{
		}
		//GetRadius
		public void GetRadius()
		{
		}
		public virtual void OnCollision(GameObject otherObj)
		{ 
		
		}


	}
}
