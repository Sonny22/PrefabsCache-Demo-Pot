using UnityEngine;
using System.Collections;

namespace PrefabsCache.Demo
{
	public class SpawnObstacle : MonoBehaviour 
	{
		public Prefab obstacle;

		public float direction = 1f;

		public int luck = 33;

		void Start()
		{
			if (obstacle == Prefab.None)
				return;

			InvokeRepeating("RegularUpdate", 0.2f, 0.2f);
		}

		void RegularUpdate() 
		{
			if (Random.Range(0, 101) < luck)
			{
				GameObject g = obstacle.GetInstance();
				
				g.transform.position = transform.position;

				g.GetComponent<Rigidbody>().velocity = (Vector3.right * 5f * direction);
				
				Prefab.FreeInstance(g, 3f);
			}
		}
	}
}