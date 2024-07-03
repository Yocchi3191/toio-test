using UnityEngine;
using toio;

namespace ToioMoveLibrary
{
	public class ToioMove : MonoBehaviour
	{
		public static void Rotate(Cube cube, int angularVelocity, int duration)
		{
			// = = = = = = = = = = = = = = = = = = = = = = = = =
			// Cubeをその場で回転させる
			// 角速度(angularVelocity)は時計回り方向を正とする
			// = = = = = = = = = = = = = = = = = = = = = = = = =

			cube.Move(angularVelocity, -angularVelocity, duration);
		}
		public static void Pick(Cube cube, int pickRate)
		{
			// = = = = = = = = = = = = = = = = = = = = = = = = =
			// Cubeをつつかせる
			// pickRateはつつく頻度(1分あたり)
			// = = = = = = = = = = = = = = = = = = = = = = = = =
			cube.collisionCallback.AddListener("ToioMove", OnCollision);

			int remainCount = pickRate;
			while (remainCount > 0)
			{
			}

			void OnCollision(Cube cube)
			{

			}
		}
	}
}