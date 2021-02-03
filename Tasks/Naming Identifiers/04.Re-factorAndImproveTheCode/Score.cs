using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Re_factorAndImproveTheCode
{
	public class Score
	{
		string name;
		int points;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Points
		{
			get { return points; }
			set { points = value; }
		}

		public Score() { }

		public Score(string name, int points)
		{
			this.name = name;
			this.points = points;
		}
	}
}
