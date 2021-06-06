

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
	public class Engine : Engine_Base
	{
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

		/** GetCursorPos
		*/
		public UnityEngine.Vector2 GetCursorPos()
		{
			return new UnityEngine.Vector2(UnityEngine.Input.mousePosition.x / UnityEngine.Screen.width,1.0f - UnityEngine.Input.mousePosition.y / UnityEngine.Screen.height);
		}

		/** GetLeftButton
		*/
		public bool GetLeftButton()
		{
			return UnityEngine.Input.GetMouseButton(0);
		}

		/** GetRightButton
		*/
		public bool GetRightButton()
		{
			return UnityEngine.Input.GetMouseButton(1);
		}

		/** GetCenterButton
		*/
		public bool GetCenterButton()
		{
			return UnityEngine.Input.GetMouseButton(2);
		}

		/** GetWheelDelta
		*/
		public UnityEngine.Vector2 GetWheelDelta()
		{
			return UnityEngine.Input.mouseScrollDelta;
		}
	}
}

