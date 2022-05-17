

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エンジン。
*/


/** define
*/
#if(ASMDEF_COM_UNITY_INPUTSYSTEM)
#define ASMDEF_TRUE
#else
#warning "ASMDEF_TRUE"
#endif


/** BlueBack.Mouse.UIS
*/
#if(ASMDEF_TRUE)
namespace BlueBack.Mouse.UIS
{
	/** Param
	*/
	public struct Param
	{
		/** device
		*/
		public UnityEngine.InputSystem.Mouse device;

		/** enable
		*/
		public bool enable;
	}
}
#endif

