

/** BlueBack.Mouse.Samples.InputSystem
*/
#if(!DEF_BLUEBACK_MOUSE_SAMPLES_DISABLE)
namespace BlueBack.Mouse.Samples.InputSystem
{
	/** Main_MonoBehaviour
	*/
	public sealed class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		#if(ENABLE_INPUT_SYSTEM)

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
			//initparam_uis
			BlueBack.Mouse.UIS.InitParam t_initparam_uis = BlueBack.Mouse.UIS.InitParam.CreateDefault();

			//Update用。
			{
				BlueBack.Mouse.InitParam t_initparam = BlueBack.Mouse.InitParam.CreateDefault();
				{
					t_initparam.updatemode = UpdateMode.UnityUpdate;
					t_initparam.engine = new BlueBack.Mouse.UIS.Engine(t_initparam_uis);
				}
				this.mouse = new BlueBack.Mouse.Mouse(in t_initparam);
			}

			//FixedUpdate用。
			{
				BlueBack.Mouse.InitParam t_initparam = BlueBack.Mouse.InitParam.CreateDefault();
				{
					t_initparam.updatemode = UpdateMode.UnityFixedUpdate;
					t_initparam.engine = new BlueBack.Mouse.UIS.Engine(t_initparam_uis);
				}
				this.mouse_fixedupdate = new BlueBack.Mouse.Mouse(in t_initparam);
			}
		}

		/** Update
		*/
		private void Update()
		{
			if(this.mouse.left.down == true){
				UnityEngine.Debug.Log(string.Format("Update.Left.Down : x = {0} : y = {1}",this.mouse.cursor.pos.x,this.mouse.cursor.pos.y));
			}
		}

		/** FixedUpdate
		*/
		private void FixedUpdate()
		{
			if(this.mouse_fixedupdate.left.down == true){
				UnityEngine.Debug.Log(string.Format("FixedUpdate.Left.Down : x = {0} : y = {1}",this.mouse.cursor.pos.x,this.mouse.cursor.pos.y));
			}
		}

		#endif
	}
}
#endif

