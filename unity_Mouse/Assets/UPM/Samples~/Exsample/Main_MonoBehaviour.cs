

/** Samples.Mouse.Exsample
*/
namespace Samples.Mouse.Exsample
{
	/** Main_MonoBehaviour
	*/
	public class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** Start
		*/
		private void Start()
		{
			BlueBack.Mouse.Mouse.CreateInstance();
		}

		/** Update
		*/
		private void Update()
		{
			BlueBack.Mouse.Mouse.GetInstance().Update();

			UnityEngine.Debug.Log("x " + BlueBack.Mouse.Mouse.GetInstance().position.x.ToString("0.00"));
			UnityEngine.Debug.Log("y " + BlueBack.Mouse.Mouse.GetInstance().position.y.ToString("0.00"));
			UnityEngine.Debug.Log("w " + BlueBack.Mouse.Mouse.GetInstance().wheel.ToString("0.00"));
			UnityEngine.Debug.Log("l " + BlueBack.Mouse.Mouse.GetInstance().left.ToString());
			UnityEngine.Debug.Log("r " + BlueBack.Mouse.Mouse.GetInstance().right.ToString());
			UnityEngine.Debug.Log("c " + BlueBack.Mouse.Mouse.GetInstance().center.ToString());
		}
	}
}

