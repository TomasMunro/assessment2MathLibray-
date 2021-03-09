using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib;
using static Raylib.Raylib;
//using Vector2 = global::mathlibrary.Vector2;

namespace Project2D
{
	class Player
	{
		private Image playerImageFile;
		Texture2D playerSprite;
		private Vector2 transform = new Vector2();

		public Player()
		{
			playerImageFile = LoadImage("../Images/dfdf.png");
			playerSprite = LoadTextureFromImage(playerImageFile);


		}

		public void Update()
		{
			transform.x += 0.1f;




		}

		public void Draw()
		{
			
			DrawTexture(playerSprite,
				(int)transform.x, (int)transform.y, Color.WHITE);
			
		}

	}
}
