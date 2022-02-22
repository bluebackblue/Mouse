

/** BlueBack.Mouse.Samples.InputSystem
*/
namespace BlueBack.Mouse.Samples.InputSystem
{
	/** Main_MonoBehaviour
	*/
	public class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** Update用。
		*/
		#if(ENABLE_INPUT_SYSTEM)
		private BlueBack.Mouse.Mouse mouse;
		#endif

		/** FixedUpdate用。
		*/
		private BlueBack.Mouse.Mouse mouse_fixedupdate;

		/** Start
		*/
		private void Start()
		{
			//Update用。
			#if(ENABLE_INPUT_SYSTEM)
			{
				BlueBack.Mouse.UIS.InitParam t_initparam = BlueBack.Mouse.UIS.InitParam.CreateDefault();
				BlueBack.Mouse.Engine_Base t_engine = new BlueBack.Mouse.UIS.Engine(t_initparam);
				this.mouse = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.Update,BlueBack.Mouse.InitParam.CreateDefault(),t_engine);
			}
			#endif

			//FixedUpdate用。
			#if(ENABLE_INPUT_SYSTEM)
			{
				BlueBack.Mouse.UIS.InitParam t_initparam = BlueBack.Mouse.UIS.InitParam.CreateDefault();
				BlueBack.Mouse.Engine_Base t_engine = new BlueBack.Mouse.UIS.Engine(t_initparam);
				this.mouse_fixedupdate = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.FixedUpdate,BlueBack.Mouse.InitParam.CreateDefault(),t_engine);
			}
			#endif
		}

		/** Update
		*/
		#if(ENABLE_INPUT_SYSTEM)
		private void Update()
		{
			if(this.mouse.left.down == true){
				UnityEngine.Debug.Log("Update.Left.Down");
			}
		}
		#endif

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

