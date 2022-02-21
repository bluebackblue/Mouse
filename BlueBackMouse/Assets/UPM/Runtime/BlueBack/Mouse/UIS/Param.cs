

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エンジン。
*/


/** BlueBack.Mouse.UIS
*/
namespace BlueBack.Mouse.UIS
{
	/** Param
	*/
	#if(ENABLE_INPUT_SYSTEM)
	public struct Param
	{
		/** device
		*/
		public UnityEngine.InputSystem.Mouse device;

		/** enable
		*/
		public bool enable;
	}
	#endif
}

