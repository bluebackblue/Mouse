

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エンジン。
*/


/** BlueBack.Mouse.UIS
*/
namespace BlueBack.Mouse.UIS
{
	/** InitParam
	*/
	#if(ENABLE_INPUT_SYSTEM)
	public struct InitParam
	{
		/** device
		*/
		public UnityEngine.InputSystem.Mouse device;

		/** CreateDefault
		*/
		public static InitParam CreateDefault()
		{
			return new InitParam(){
				device = UnityEngine.InputSystem.Mouse.current,
			};
		}
	}
	#endif
}

