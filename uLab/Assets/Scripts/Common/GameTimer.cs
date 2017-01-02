
using UnityEngine;

namespace Lite
{

	public class GameTimer
	{
		public static float realtimeSinceStartup
		{
			get { return Time.realtimeSinceStartup; }
		}

		public static float deltaTime 
		{
			get { return Time.deltaTime; }
		}

		public static float timeSinceLevelLoad
		{
			get { return Time.timeSinceLevelLoad; }
		}

	}

}