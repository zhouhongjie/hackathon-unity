using UnityEngine;
using System.Collections.Generic;

public class TekkenVirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
		Animation anim;
		List<AnimationState> animState;
		private int index;
		public GameObject imgTarget;
		public void OnCreateAnimationPlay ()
		{

				//Debug.Log (obj.name);
				animState = new List<AnimationState> ();
				Debug.Log (gameObject.name);
				Debug.Log (gameObject.transform.GetChild (1).name);
				anim = imgTarget.transform.GetChild (1).GetComponent<Animation> ();
				foreach (AnimationState clip in anim) {
						animState.Add (clip);
				}
				index = 0;
				anim.Play (animState [index].name);
				Debug.Log (animState.Count);
				Debug.Log (animState [index].name);

		}
	
		/// <summary>
		/// Called when the scene is loaded
		/// </summary>
		void Start ()
		{
				// Search for all Children from this ImageTarget with type VirtualButtonBehaviour
				VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour> ();
				for (int i = 0; i < vbs.Length; ++i) {
						// Register with the virtual buttons TrackableBehaviour
						vbs [i].RegisterEventHandler (this);
						vbs [i].UpdateAreaRectangle ();
				}
		}
	
		/// <summary>
		/// Called when the virtual button has just been pressed:
		/// </summary>
		public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
		{
				if (index < animState.Count - 1) {
						index++;
				} else {
						index = 0;
				}
				anim.Play (animState [index].name);
		}
	
		/// <summary>
		/// Called when the virtual button has just been released:
		/// </summary>
		public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
		{
		}
}