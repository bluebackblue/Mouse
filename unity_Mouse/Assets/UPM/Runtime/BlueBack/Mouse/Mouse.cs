

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
		public StatusCursor cursor;

		/** ホイール。
		*/
		public StatusWheel wheel;

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
			//cursor
			this.cursor.Reset();

			//wheel
			this.wheel.Reset();

			//button
			this.left.Reset();
			this.right.Reset();
			this.center.Reset();
		}

		/** DeviceUpdate
		*/
		public void DeviceUpdate()
		{
			//cursor
			this.cursor.pos = new UnityEngine.Vector2(UnityEngine.Input.mousePosition.x / UnityEngine.Screen.width,1.0f - UnityEngine.Input.mousePosition.y / UnityEngine.Screen.height);

			//pos
			this.wheel.device_accumulation += UnityEngine.Input.mouseScrollDelta;

			//最新の状態。
			this.left.device = UnityEngine.Input.GetMouseButton(0);
			this.right.device = UnityEngine.Input.GetMouseButton(1);
			this.center.device = UnityEngine.Input.GetMouseButton(2);

			//累積。
			this.left.device_accumulation |= this.left.device;
			this.right.device_accumulation |= this.right.device;
			this.center.device_accumulation |= this.center.device;
		}

		/** StatusUpdate
		*/
		public void StatusUpdate()
		{
			//button
			this.left.Update();
			this.right.Update();
			this.center.Update();
			this.left.device_accumulation = this.left.device;
			this.right.device_accumulation = this.right.device;
			this.center.device_accumulation = this.center.device;

			//wheel
			this.wheel.Update();
			this.wheel.device_accumulation = new UnityEngine.Vector2(0.0f,0.0f);
		}
	}
}

