

/** BlueBack.Mouse.Samples.InputManager
*/
namespace BlueBack.Mouse.Samples.InputManager
{
	/** Main_MonoBehaviour
	*/
	public class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** Update用。
		*/
		private BlueBack.Mouse.Mouse mouse;

		/** FixedUpdate用。
		*/
		private BlueBack.Mouse.Mouse mouse_fixedupdate;

		/** Start
		*/
		private void Start()
		{
			//Update用。
			{
				BlueBack.Mouse.UIM.InitParam t_initparam = BlueBack.Mouse.UIM.InitParam.CreateDefault();
				BlueBack.Mouse.Engine_Base t_engine = new BlueBack.Mouse.UIM.Engine(t_initparam);
				this.mouse = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.Update,BlueBack.Mouse.InitParam.CreateDefault(),t_engine);
			}

			//FixedUpdate用。
			{
				BlueBack.Mouse.UIM.InitParam t_initparam = BlueBack.Mouse.UIM.InitParam.CreateDefault();
				BlueBack.Mouse.Engine_Base t_engine = new BlueBack.Mouse.UIM.Engine(t_initparam);
				this.mouse_fixedupdate = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.FixedUpdate,BlueBack.Mouse.InitParam.CreateDefault(),t_engine);
			}
		}

		/** Update
		*/
		private void Update()
		{
			if(this.mouse.left.down == true){
				UnityEngine.Debug.Log("Update.Left.Down");
			}
		}

		/** FixedUpdate
		*/
		private void FixedUpdate()
		{
			if(this.mouse_fixedupdate.left.down == true){
				UnityEngine.Debug.Log("FixedUpdate.Left.Down");
			}
		}
	}
}

