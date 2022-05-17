

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief エンジン。
*/


/** BlueBack.Mouse.UIM
*/
namespace BlueBack.Mouse.UIM
{
	/** InitParam
	*/
	public struct InitParam
	{
		/** button
		*/
		public int button_l;
		public int button_r;
		public int button_c;

		/** CreateDefault
		*/
		public static InitParam CreateDefault()
		{
			return new InitParam(){
				button_l = 0,
				button_r = 1,
				button_c = 2,
			};
		}
	}
}

