using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2D
{
	class Level: GameObject
	{
		private Tank m_tank = null;
		public Level() : base("")
		{
			m_tank = new Tank("../Images/TankBase.png");
			m_tank.SetParent(this);
		
		}

	}
}
