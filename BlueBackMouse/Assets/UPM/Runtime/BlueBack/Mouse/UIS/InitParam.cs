

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief エンジン。
*/


/** BlueBack.Mouse.UIS
*/
namespace BlueBack.Mouse.UIS
{
	/** Param
	*/
	#if(ENABLE_INPUT_SYSTEM)
	public struct InitParam
	{
		/** device
		*/
		public UnityEngine.InputSystem.Mouse device;

		/** constructor
		*/
		public InitParam(UnityEngine.InputSystem.Mouse a_device)
		{
			this.device = a_device;
		}
	}
	#endif
}

