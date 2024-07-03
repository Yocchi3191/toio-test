using UnityEngine;
using toio;
using System.Collections;

namespace toio.tutorial
{
	public class CollisionScene : MonoBehaviour
	{
		// Start is called before the first frame update
		CubeManager cubeManager;
		Cube cube;
		[SerializeField] int moveSpeed;

		IEnumerator stop()
		{
			yield return new WaitForSeconds(1);
		}
		async void Start()
		{
			cubeManager = new CubeManager();
			cube = await cubeManager.SingleConnect();
			cube.collisionCallback.AddListener("CollisionScene", OnCollision);
		}

		// Update is called once per frame
		void Update()
		{
			cube.Move(moveSpeed, moveSpeed, 200);
		}

		void OnCollision(Cube cube)
		{
			Debug.Log("ぶつかった！");
			cube.PlayPresetSound(2);
			StartCoroutine("stop");
			moveSpeed = -moveSpeed;
		}
	}
}