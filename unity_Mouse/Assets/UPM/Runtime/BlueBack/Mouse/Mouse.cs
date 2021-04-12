

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief マウス。
*/


/** BlueBack.Mouse
*/
namespace BlueBack.Mouse
{
	/** Mouse
	*/
	public class Mouse : System.IDisposable
	{
		/** カーソル。
		*/
		public StatusPosition cursor;

		/** マウスホイール。
		*/
		public StatusPosition wheel;

		/** 左ボタン。
		*/
		public StatusButton left;

		/** 右ボタン。
		*/
		public StatusButton right;

		/** 中ボタン。
		*/
		public StatusButton center;

		/** constructor
		*/
		public Mouse(Mode a_mode,Param a_param)
		{
			UnityEngine.LowLevel.PlayerLoopSystem t_playerloopsystem = BlueBack.UnityPlayerLoop.UnityPlayerLoop.GetCurrentPlayerLoop();

			//StatusUpdate
			switch(a_mode){
			case Mode.FixedUpdate:
				{
					BlueBack.UnityPlayerLoop.Add.AddFromType(ref t_playerloopsystem,UnityPlayerLoop.Mode.AddFirst,typeof(UnityEngine.PlayerLoop.FixedUpdate),typeof(PlayerLoopType.Update),this.StatusUpdate);
				}break;
			case Mode.Update:
				{
					BlueBack.UnityPlayerLoop.Add.AddFromType(ref t_playerloopsystem,UnityPlayerLoop.Mode.AddFirst,typeof(UnityEngine.PlayerLoop.Update),typeof(PlayerLoopType.Update),this.StatusUpdate);
				}break;
			case Mode.Manual:
				{
				}break;
			}

			//DeviceUpdate
			BlueBack.UnityPlayerLoop.Add.AddFromType(ref t_playerloopsystem,UnityPlayerLoop.Mode.AddFirst,typeof(UnityEngine.PlayerLoop.Update),typeof(PlayerLoopType.Update),this.DeviceUpdate);

			//SetPlayerLoop
			BlueBack.UnityPlayerLoop.UnityPlayerLoop.SetPlayerLoop(t_playerloopsystem);

			//Init
			this.cursor.Init();
			this.wheel.Init();
			this.left.Init(a_param);
			this.right.Init(a_param);
			this.center.Init(a_param);
		}

		/** [IDisposable]Dispose。
		*/
		public void Dispose()
		{
			UnityEngine.LowLevel.PlayerLoopSystem t_playerloopsystem = BlueBack.UnityPlayerLoop.UnityPlayerLoop.GetCurrentPlayerLoop();
			BlueBack.UnityPlayerLoop.Remove.RemoveFromType(ref t_playerloopsystem,typeof(PlayerLoopType.Update));
		}

		/** Reset
		*/
		public void Reset()
		{
			this.cursor.Reset();
			this.wheel.Reset();
			this.left.Reset();
			this.right.Reset();
			this.center.Reset();
		}

		/** DeviceUpdate
		*/
		public void DeviceUpdate()
		{
			this.cursor.device = new UnityEngine.Vector2(UnityEngine.Input.mousePosition.x / UnityEngine.Screen.width,1.0f - UnityEngine.Input.mousePosition.y / UnityEngine.Screen.height);
			this.wheel.device += UnityEngine.Input.mouseScrollDelta;
			this.left.device |= UnityEngine.Input.GetMouseButton(0);
			this.right.device |= UnityEngine.Input.GetMouseButton(1);
			this.center.device |= UnityEngine.Input.GetMouseButton(2);
		}

		/** StatusUpdate
		*/
		public void StatusUpdate()
		{
			this.cursor.Update();
			this.wheel.Update();
			this.left.Update();
			this.right.Update();
			this.center.Update();

			this.wheel.device = new UnityEngine.Vector2(0.0f,0.0f);
			this.left.device = false;
			this.right.device = false;
			this.center.device = false;
		}
	}
}

