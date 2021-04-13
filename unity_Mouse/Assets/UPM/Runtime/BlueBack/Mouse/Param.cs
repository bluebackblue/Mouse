

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief コンフィグ。
*/


/** BlueBack.Mouse
*/
namespace BlueBack.Mouse
{
	/** Param
	*/
	public class Param
	{
		/** 初回のラピッド間隔。
		*/
		public float rapid_time_max_first;

		/** 二回目からのラピッド間隔。
		*/
		public float rapid_time_max;

		/** constructor
		*/
		public Param()
		{
			//rapid_time_max_first
			this.rapid_time_max_first = 0.5f;

			//rapid_time_max
			this.rapid_time_max = 0.1f;
		}
	}
}

