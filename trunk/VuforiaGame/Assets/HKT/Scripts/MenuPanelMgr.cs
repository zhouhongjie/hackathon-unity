using UnityEngine;
using System.Collections;

public class MenuPanelMgr : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
		public void PlayGame ()
		{
				Application.LoadLevelAsync ("MainScene");
		}
}
