using UnityEngine;
using System.Collections;

public class GameMgr : MonoBehaviour
{
		public GameObject[] listAnimal;
		GameObject currentObject;
		int i ;
		// Use this for initialization
		void Start ()
		{
				int i = 0;
				currentObject = Instantiate (listAnimal [i], new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
				currentObject.transform.parent = gameObject.transform;
				currentObject.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		}

		void OnGUI ()
		{
				
				if (GUI.Button (new Rect (300, 100, 100, 100), "next")) {
						i ++;
						if (i >= listAnimal.Length)
								i = 0;
						GameObject.Destroy (currentObject);
						currentObject = Instantiate (listAnimal [i], new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
						currentObject.transform.parent = gameObject.transform;
						currentObject.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
				}

				if (GUI.Button (new Rect (100, 300, 100, 100), "sound")) {
						AudioSource audio = currentObject.GetComponent<AudioSource> () as AudioSource;
						if (audio != null && !audio.isPlaying)
								audio.Play ();
				}
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
