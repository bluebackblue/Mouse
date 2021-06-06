

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief エンジン。
*/


/** BlueBack.Mouse
*/
namespace BlueBack.Mouse
{
	/** Engine_Base
	*/
	public interface Engine_Base
	{
		/** [BlueBack.Mouse.Engine_Base]作成。
		*/
		void Create();

		/** [BlueBack.Mouse.Engine_Base]削除。
		*/
		void Delete();

		/** GetCursorPos
		*/
		UnityEngine.Vector2 GetCursorPos();

		/** GetLeftButton
		*/
		bool GetLeftButton();

		/** GetRightButton
		*/
		bool GetRightButton();

		/** GetCenterButton
		*/
		bool GetCenterButton();

		/** GetWheelDelta
		*/
		UnityEngine.Vector2 GetWheelDelta();
	}
}

