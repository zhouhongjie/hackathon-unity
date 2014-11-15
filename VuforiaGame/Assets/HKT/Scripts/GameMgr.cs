using UnityEngine;
using System.Collections;

public class GameMgr : MonoBehaviour
{
		public GameObject[] listAnimal;
		public GameObject GridViewAnimal;
		public GameObject labelInfo;
		public GameObject ViewAnimal;
		public GameObject imgTarget;
		public UIScrollView ScrollView;

		public GameObject InfoPanel;
		public GameObject ShowInfoPanelBtn;

		public void showInfoPanel ()
		{
				InfoPanel.SetActive (true);
				ShowInfoPanelBtn.SetActive (false);
		}
		public void hideInfoPanel ()
		{
				InfoPanel.SetActive (false);
				ShowInfoPanelBtn.SetActive (true);
		}
		//		int count ;
		// Use this for initialization
		void initFirstAnimal ()
		{
				GameObject firstAnimal = Instantiate (listAnimal [2], new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
				firstAnimal.transform.parent = imgTarget.transform;
				firstAnimal.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
				labelInfo.GetComponent<UILabel> ().text = AnimalDB.Instance.info [2];
		}

		void Start ()
		{
				initFirstAnimal ();
				for (int i = 0; i < AnimalDB.Instance.name.Length; i++) {
						ViewAnimal.transform.GetChild (0).GetComponent<UILabel> ().text = AnimalDB.Instance.name [i];	
						ViewAnimal.transform.GetChild (1).GetComponent<UISprite> ().spriteName = AnimalDB.Instance.name [i];	
						GameObject viewAnimalObject = NGUITools.AddChild (GridViewAnimal, ViewAnimal);
						Vector2 pos = new Vector2 (-128 + i * 135, 0);
						viewAnimalObject.transform.localPosition = pos;
						viewAnimalObject.name = i.ToString ();
						viewAnimalObject.GetComponent<UIDragScrollView> ().scrollView = ScrollView;
						if (viewAnimalObject.GetComponent<UpdateInfo> () != null) {
								viewAnimalObject.GetComponent<UpdateInfo> ().labelInfo = labelInfo;
								viewAnimalObject.GetComponent<UpdateInfo> ().imgTarget = imgTarget;
								viewAnimalObject.GetComponent<UpdateInfo> ().listAnimal = listAnimal;
						} else {
								Debug.Log ("ehhh");
						}
				}					
		}

		public void playSound ()
		{
				GameObject currentObject = imgTarget.transform.GetChild (0).gameObject;
				AudioSource audio = currentObject.GetComponent<AudioSource> () as AudioSource;
				if (audio != null && !audio.isPlaying)
						audio.Play ();
		}
	
		// Update is called once per frame
		void Update ()
		{

		}
}
