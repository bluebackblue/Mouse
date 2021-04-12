

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
		/** device
		*/
		public bool device;

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
		*/
		public bool rapid;
		public int rapid_time;

		/** 初回のラピッド間隔。
		*/
		public int rapid_time_max_first;

		/** 二回目からのラピッド間隔。
		*/
		public int rapid_time_max;

		/** 更新。
		*/
		public void Update()
		{
			if((this.device == true)&&(this.on == false)){
				//ダウン。
				this.on = true;
				this.down = true;
				this.up = false;
				this.rapid = true;
				this.rapid_time = this.rapid_time_max_first;
			}else if((this.device == false)&&(this.on == true)){
				//アップ。
				this.on = false;
				this.down = false;
				this.up = true;
				this.rapid = false;
				this.rapid_time = 0;
			}else if(this.device == true){
				//オン。
				this.on = true;
				this.down = false;
				this.up = false;

				this.rapid_time--;
				if(this.rapid_time <= 0){
					this.rapid_time = this.rapid_time_max;
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
			this.on = false;
			this.down = false;
			this.up = false;

			this.rapid = false;
			this.rapid_time  = 0;
		}

		/** 初期化。
		*/
		public void Init(Param a_param)
		{
			this.device = false;
			this.on = false;
			this.down = false;
			this.up = false;

			this.rapid = false;
			this.rapid_time  = 0;

			this.rapid_time_max_first = a_param.rapid_time_max_first;
			this.rapid_time_max = a_param.rapid_time_max;
		}
	}
}

