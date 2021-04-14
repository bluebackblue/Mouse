

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief ステータス。
*/


/** BlueBack.Mouse
*/
namespace BlueBack.Mouse
{
	/** StatusButton
	*/
	public struct StatusButton
	{
		/** 最新の状態。
		*/
		public bool device;

		/** 累積。
		*/
		public bool device_accumulation;

		/** on
		*/
		public bool on;

		/** down
		*/
		public bool down;

		/** up
		*/
		public bool up;

		/** rapid

			rapid_time				: 次回ラピッド時刻。
			rapid_time_max_first	: 初回のラピッド間隔。
			rapid_time_max			: 二回目からのラピッド間隔。

		*/
		public bool rapid;
		public float rapid_time;
		public float rapid_time_max_first;
		public float rapid_time_max;

		/** 更新。
		*/
		public void Update()
		{
			if((this.device_accumulation == true)&&(this.on == false)){
				//ダウン。
				this.on = true;
				this.down = true;
				this.up = false;
				this.rapid = true;
				this.rapid_time = UnityEngine.Time.realtimeSinceStartup + this.rapid_time_max_first;
			}else if((this.device_accumulation == false)&&(this.on == true)){
				//アップ。
				this.on = false;
				this.down = false;
				this.up = true;
				this.rapid = false;
			}else if(this.device_accumulation == true){
				//オン。
				this.on = true;
				this.down = false;
				this.up = false;

				float t_real_time = UnityEngine.Time.realtimeSinceStartup;
				if(this.rapid_time <= t_real_time){
					this.rapid_time += this.rapid_time_max;
					if((this.rapid_time - t_real_time) <= this.rapid_time_max * 0.3f){
						this.rapid_time = t_real_time + this.rapid_time_max;
					}
					this.rapid = true;
				}else{
					this.rapid = false;
				}
			}else{
				//オフ。
				this.on = false;
				this.down = false;
				this.up = false;
				this.rapid = false;
			}
		}

		/** リセット。
		*/
		public void Reset()
		{
			this.device = false;
			this.device_accumulation = false;
			this.on = false;
			this.down = false;
			this.up = false;
			this.rapid = false;
			this.rapid_time  = 0.0f;
		}

		/** 初期化。
		*/
		public void Init(Param a_param)
		{
			this.device = false;
			this.device_accumulation = false;
			this.on = false;
			this.down = false;
			this.up = false;
			this.rapid = false;
			this.rapid_time  = 0.0f;
			this.rapid_time_max_first = a_param.rapid_time_max_first;
			this.rapid_time_max = a_param.rapid_time_max;
		}
	}
}

