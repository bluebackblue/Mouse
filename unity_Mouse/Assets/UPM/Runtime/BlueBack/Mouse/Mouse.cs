

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
		/** engine
		*/
		public Engine_Base engine;

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
		public Mouse(Mode a_mode,Param a_param,Engine_Base a_engine)
		{
			//PlayerLoopSystem
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
			}

			//engine
			this.engine = a_engine;
			this.engine.Create();

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
			//engine
			this.engine.Delete();
			
			//PlayerLoopSystem
			UnityEngine.LowLevel.PlayerLoopSystem t_playerloopsystem = BlueBack.UnityPlayerLoop.UnityPlayerLoop.GetCurrentPlayerLoop();
			BlueBack.UnityPlayerLoop.Remove.RemoveFromType(ref t_playerloopsystem,typeof(PlayerLoopType.Update));
			BlueBack.UnityPlayerLoop.UnityPlayerLoop.SetPlayerLoop(t_playerloopsystem);
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
			this.cursor.pos = this.engine.GetCursorPos();

			//pos
			this.wheel.device_accumulation += this.engine.GetWheelDelta();

			//最新の状態。
			this.left.device = this.engine.GetLeftButton();
			this.right.device = this.engine.GetRightButton();
			this.center.device = this.engine.GetCenterButton();

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

