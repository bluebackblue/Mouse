

/** Samples.Mouse.Exsample
*/
namespace Samples.Mouse.Exsample
{
	/** Main_MonoBehaviour
	*/
	public class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** mouse_update
		*/
		private BlueBack.Mouse.Mouse mouse_update;

		/** mouse_fixedupdate
		*/
		private BlueBack.Mouse.Mouse mouse_fixedupdate;

		/** マニュアル呼び出し。
		*/
		private BlueBack.Mouse.Mouse mouse_manual;

		/** 表示。
		*/
		private UnityEngine.UI.Text text_update;
		private UnityEngine.UI.Text text_fixedupdate;
		private UnityEngine.UI.Text text_manual;
		private int value_update;
		private int value_fixedupdate;
		private int value_manual;
		private UnityEngine.Vector2 value_wheel_update;
		private UnityEngine.Vector2 value_wheel_fixedupdate;
		private UnityEngine.Vector2 value_wheel_manual;

		/** Start
		*/
		private void Start()
		{
			//mouse_update
			this.mouse_update = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.Update,new BlueBack.Mouse.Param());

			//mouse_fixedupdate
			this.mouse_fixedupdate = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.FixedUpdate,new BlueBack.Mouse.Param());

			//マニュアル呼び出し。
			this.mouse_manual = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.Manual,new BlueBack.Mouse.Param());

			//表示。
			this.text_update = UnityEngine.GameObject.Find("Text_Update").GetComponent<UnityEngine.UI.Text>();
			this.text_fixedupdate = UnityEngine.GameObject.Find("Text_FixedUpdate").GetComponent<UnityEngine.UI.Text>();
			this.text_manual = UnityEngine.GameObject.Find("Text_Manual").GetComponent<UnityEngine.UI.Text>();
			this.value_update = 0;
			this.value_fixedupdate = 0;
			this.value_manual = 0;
			this.value_wheel_update = new UnityEngine.Vector2(0.0f,0.0f);
			this.value_wheel_fixedupdate = new UnityEngine.Vector2(0.0f,0.0f);
			this.value_wheel_manual = new UnityEngine.Vector2(0.0f,0.0f);
		}

		/** Update
		*/
		private void Update()
		{
			if(this.mouse_update.left.rapid == true){
				this.value_update++;
			}

			if(this.mouse_update.right.down == true){
				this.value_update--;
			}

			this.value_wheel_update += this.mouse_update.wheel.pos;
		}

		/** FixedUpdate
		*/
		private void FixedUpdate()
		{
			if(this.mouse_fixedupdate.left.rapid == true){
				this.value_fixedupdate++;
			}
			if(this.mouse_fixedupdate.right.down == true){
				this.value_fixedupdate--;
			}

			this.value_wheel_fixedupdate += this.mouse_fixedupdate.wheel.pos;
		}

		/** LateUpdate
		*/
		private void LateUpdate()
		{
			//マニュアル呼び出し。
			this.mouse_manual.StatusUpdate();

			if(this.mouse_manual.left.rapid == true){
				this.value_manual++;
			}
			if(this.mouse_manual.right.down == true){
				this.value_manual--;
			}

			this.value_wheel_manual += this.mouse_manual.wheel.pos;

			this.text_update.text = string.Format("{0} {1} {2} {3:0.000} {4:0.000}",this.value_update,this.value_wheel_update.x,this.value_wheel_update.y,this.mouse_update.cursor.pos.x,this.mouse_update.cursor.pos.y);
			this.text_fixedupdate.text = string.Format("{0} {1} {2} {3:0.000} {4:0.000}",this.value_fixedupdate,this.value_wheel_fixedupdate.x,this.value_wheel_fixedupdate.y,this.mouse_fixedupdate.cursor.pos.x,this.mouse_fixedupdate.cursor.pos.y);
			this.text_manual.text = string.Format("{0} {1} {2} {3:0.000} {4:0.000}",this.value_manual,this.value_wheel_manual.x,this.value_wheel_manual.y,this.mouse_manual.cursor.pos.x,this.mouse_manual.cursor.pos.y);
		}
	}
}

