using UnityEngine;
using System.Collections;

namespace PrefabsCache.Demo
{
	public class GameManager : MonoBehaviour 
	{
		public GUIStyle labelStyle;

		private bool gameWon = false;

		void OnTriggerEnter(Collider other)
		{
			if(other.tag == "Player")
				gameWon = true;
		}

		void OnGUI()
		{
			if (gameWon)
			{
				GUI.Label(new Rect(0, 0, Screen.width, Screen.height / 2f), "You won!", labelStyle);

				if (GUI.Button(new Rect((Screen.width - 250f) / 2f, Screen.height / 2f + 20f, 250f, 80f), "Restart"))
#if UNITY_5_4_OR_NEWER
					UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
#else
					Application.LoadLevel(Application.loadedLevel);
#endif
			}
			else
			{
				GUI.Label(new Rect(0, 0, Screen.width, Screen.height / 4f), "Press space and\r\n put a ball in the pot.", labelStyle);
			}
		}
	}
}