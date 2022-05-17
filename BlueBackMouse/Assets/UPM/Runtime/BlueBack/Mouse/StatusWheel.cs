

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ステータス。
*/


/** BlueBack.Mouse
*/
namespace BlueBack.Mouse
{
	/** StatusWheel
	*/
	public struct StatusWheel
	{
		/** 累積。
		*/
		public UnityEngine.Vector2 device_accumulation;

		/** 位置。
		*/
		public UnityEngine.Vector2 pos;

		/** 更新。
		*/
		public void Update()
		{
			this.pos = this.device_accumulation;
		}

		/** リセット。
		*/
		public void Reset()
		{
			this.device_accumulation = new UnityEngine.Vector2(0.0f,0.0f);
			this.pos = new UnityEngine.Vector2(0.0f,0.0f);
		}

		/** 初期化。
		*/
		public void Init()
		{
			this.device_accumulation = new UnityEngine.Vector2(0.0f,0.0f);
			this.pos = new UnityEngine.Vector2(0.0f,0.0f);
		}
	}
}

