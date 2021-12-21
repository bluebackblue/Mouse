

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief エンジン。
*/


/** BlueBack.Mouse.UIM
*/
namespace BlueBack.Mouse.UIM
{
	/** Engine
	*/
	public sealed class Engine : Engine_Base
	{
		/** param
		*/
		public InitParam param;

		/** constructor
		*/
		public Engine(in InitParam a_param)
		{
			this.param = a_param;
		}

		/** [BlueBack.Mouse.Engine_Base]作成。
		*/
		public void Create()
		{
		}

		/** [BlueBack.Mouse.Engine_Base]削除。
		*/
		public void Delete()
		{
		}

		/** [BlueBack.Mouse.Engine_Base]GetCursorPos
		*/
		public UnityEngine.Vector2 GetCursorPos()
		{
			return new UnityEngine.Vector2(UnityEngine.Input.mousePosition.x / UnityEngine.Screen.width,1.0f - UnityEngine.Input.mousePosition.y / UnityEngine.Screen.height);
		}

		/** [BlueBack.Mouse.Engine_Base]GetLeftButton
		*/
		public bool GetLeftButton()
		{
			return UnityEngine.Input.GetMouseButton(this.param.button_l);
		}

		/** [BlueBack.Mouse.Engine_Base]GetRightButton
		*/
		public bool GetRightButton()
		{
			return UnityEngine.Input.GetMouseButton(this.param.button_r);
		}

		/** [BlueBack.Mouse.Engine_Base]GetCenterButton
		*/
		public bool GetCenterButton()
		{
			return UnityEngine.Input.GetMouseButton(this.param.button_c);
		}

		/** [BlueBack.Mouse.Engine_Base]GetWheelDelta
		*/
		public UnityEngine.Vector2 GetWheelDelta()
		{
			return UnityEngine.Input.mouseScrollDelta;
		}
	}
}

