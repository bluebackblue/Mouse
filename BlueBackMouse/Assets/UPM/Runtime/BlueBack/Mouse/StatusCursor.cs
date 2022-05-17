

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ステータス。
*/


/** BlueBack.Mouse
*/
namespace BlueBack.Mouse
{
	/** StatusCursor
	*/
	public struct StatusCursor
	{
		/** 位置。
		*/
		public UnityEngine.Vector2 pos;

		/** リセット。
		*/
		public void Reset()
		{
			this.pos = new UnityEngine.Vector2(0.0f,0.0f);
		}

		/** 初期化。
		*/
		public void Init()
		{
			this.pos = new UnityEngine.Vector2(0.0f,0.0f);
		}
	}
}

