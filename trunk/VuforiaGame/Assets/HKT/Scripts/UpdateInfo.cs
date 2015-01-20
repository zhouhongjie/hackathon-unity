using UnityEngine;
using System.Collections;

public class UpdateInfo : UICenterOnClick
{
		public GameObject[] listAnimal;

		public GameObject labelInfo;
		public GameObject imgTarget;
		public GameObject gamecntroller;
		public TekkenVirtualButtonEventHandler tekken;


		void OnClick ()
		{
				labelInfo.GetComponent<UILabel> ().text = AnimalDB.Instance.info [int.Parse (gameObject.name)];
				
				GameObject.Destroy (imgTarget.transform.GetChild (1).gameObject);
				
				GameObject NextAnimal = Instantiate (listAnimal [int.Parse (gameObject.name)], new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
				NextAnimal.transform.parent = imgTarget.transform;
				NextAnimal.transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
				
				AnimalDB.Instance.currentAnimal = NextAnimal;

				tekken = gamecntroller.GetComponent<TekkenVirtualButtonEventHandler> ();

				tekken.OnCreateAnimationPlay ();
		}

		int idAnimal = 1;
}
