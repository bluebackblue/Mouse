

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エンジン。
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

		/** [BlueBack.Mouse.Engine_Base]更新。
		*/
		void PreUpdate();

		/** [BlueBack.Mouse.Engine_Base]GetCursorPos
		*/
		UnityEngine.Vector2 GetCursorPos();

		/** [BlueBack.Mouse.Engine_Base]GetLeftButton
		*/
		bool GetLeftButton();

		/** [BlueBack.Mouse.Engine_Base]GetRightButton
		*/
		bool GetRightButton();

		/** [BlueBack.Mouse.Engine_Base]GetCenterButton
		*/
		bool GetCenterButton();

		/** [BlueBack.Mouse.Engine_Base]GetWheelDelta
		*/
		UnityEngine.Vector2 GetWheelDelta();
	}
}

