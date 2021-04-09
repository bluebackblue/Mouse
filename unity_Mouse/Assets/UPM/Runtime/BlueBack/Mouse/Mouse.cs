

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief デバッグツール。
*/


/** BlueBack.Mouse
*/
namespace BlueBack.Mouse
{
	/** Mouse
	*/
	public class Mouse
	{
		private static Mouse s_instance;
		public static void CreateInstance()
		{
			if(s_instance == null){
				s_instance = new Mouse();
			}
		}
		public static Mouse GetInstance()
		{
			return s_instance;
		}
		public static bool IsCreate()
		{
			return (s_instance != null);
		}

		public UnityEngine.Vector2 position;
		public bool left;
		public bool right;
		public bool center;
		public float wheel;

		/** constructor
		*/
		private Mouse()
		{
		}

		/** Update
		*/
		public void Update()
		{
			this.position = new UnityEngine.Vector2(UnityEngine.Input.mousePosition.x / UnityEngine.Screen.width,1.0f - UnityEngine.Input.mousePosition.y / UnityEngine.Screen.height);
			this.left = UnityEngine.Input.GetMouseButton(0);
			this.right = UnityEngine.Input.GetMouseButton(1);
			this.center = UnityEngine.Input.GetMouseButton(2);
			this.wheel = UnityEngine.Input.mouseScrollDelta.y;
		}
	}
}

