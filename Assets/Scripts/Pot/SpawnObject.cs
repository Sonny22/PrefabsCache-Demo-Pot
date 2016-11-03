using UnityEngine;
using System.Collections;

namespace PrefabsCache.Demo
{
	public class SpawnObject : MonoBehaviour 
	{
		public Prefab myPrefab;

		void Update () 
		{
			if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
			{
				GameObject g = myPrefab.GetInstance();

				// if myPrefab is None
				if(g == null)
					return;

				g.transform.position = transform.position;

				// Free the instance after 2 seconds
				Prefab.FreeInstance(g, 2f);
			}
		}
	}
}