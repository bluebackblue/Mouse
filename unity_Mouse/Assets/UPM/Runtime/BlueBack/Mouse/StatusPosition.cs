

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief ステータス。
*/


/** BlueBack.Mouse
*/
namespace BlueBack.Mouse
{
	/** StatusPosition
	*/
	public struct StatusPosition
	{
		/** device
		*/
		public UnityEngine.Vector2 device;

		/** pos
		*/
		public UnityEngine.Vector2 pos;

		/** 更新。
		*/
		public void Update()
		{
			this.pos = this.device;
		}

		/** リセット。
		*/
		public void Reset()
		{
			this.pos = new UnityEngine.Vector2(0.0f,0.0f);
			this.device = new UnityEngine.Vector2(0.0f,0.0f);
		}

		/** 初期化。
		*/
		public void Init()
		{
			this.pos = new UnityEngine.Vector2(0.0f,0.0f);
			this.device = new UnityEngine.Vector2(0.0f,0.0f);
		}
	}
}

