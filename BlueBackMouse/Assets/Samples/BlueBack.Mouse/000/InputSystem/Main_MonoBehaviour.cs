

/** Samples.Mouse.InputSystem
*/
namespace Samples.Mouse.InputSystem
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
			this.mouse = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.Update,BlueBack.Mouse.InitParam.CreateDefault(),new BlueBack.Mouse.UIS.Engine(new BlueBack.Mouse.UIS.InitParam()));
			#endif

			//FixedUpdate用。
			this.mouse_fixedupdate = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.FixedUpdate,BlueBack.Mouse.InitParam.CreateDefault(),new BlueBack.Mouse.UIM.Engine());
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

