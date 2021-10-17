

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief エンジン。
*/


/** BlueBack.Mouse.UIS
*/
namespace BlueBack.Mouse.UIS
{
	/** Engine
	*/
	#if(ENABLE_INPUT_SYSTEM)
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
			if(this.param.device != null){
				return this.param.device.position.ReadValue();
			}
			return new UnityEngine.Vector2(0.0f,0.0f);
		}

		/** [BlueBack.Mouse.Engine_Base]GetLeftButton
		*/
		public bool GetLeftButton()
		{
			if(this.param.device != null){
				return this.param.device.leftButton.isPressed;
			}
			return false;
		}

		/** [BlueBack.Mouse.Engine_Base]GetRightButton
		*/
		public bool GetRightButton()
		{
			if(this.param.device != null){
				return this.param.device.rightButton.isPressed;
			}
			return false;
		}

		/** [BlueBack.Mouse.Engine_Base]GetCenterButton
		*/
		public bool GetCenterButton()
		{
			if(this.param.device != null){
				return this.param.device.middleButton.isPressed;
			}
			return false;
		}

		/** [BlueBack.Mouse.Engine_Base]GetWheelDelta
		*/
		public UnityEngine.Vector2 GetWheelDelta()
		{
			if(this.param.device != null){
				return this.param.device.scroll.ReadValue();
			}
			return new UnityEngine.Vector2(0.0f,0.0f);
		}
	}
	#endif
}

