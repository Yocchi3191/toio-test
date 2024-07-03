using UnityEngine;
using toio;
using ToioMoveLibrary;

namespace toio.tutorial
{
	public class RotateScene : MonoBehaviour
	{
		CubeManager cubeManager;
		Cube cube;
		// Start is called before the first frame update
		async void Start()
		{
			// CubeManagerからモジュールを間接利用した場合:
			cubeManager = new CubeManager();
			cube = await cubeManager.SingleConnect();
		}

		// Update is called once per frame
		void Update()
		{
			// CubeManagerからモジュールを間接利用した場合:
			if (cubeManager.IsControllable(cube))
			{
				ToioMove.Rotate(cube, 100, 200);
				// Debug.Log("回ってる！！！");
			}
		}
	}
}