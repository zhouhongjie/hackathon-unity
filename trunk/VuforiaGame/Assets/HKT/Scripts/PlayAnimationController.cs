using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayAnimationController : MonoBehaviour
{

		Animation anim;
		List<AnimationState> animState;
		private int i;

		void Awake ()
		{
				animState = new List<AnimationState> ();
				anim = gameObject.animation;
				foreach (AnimationState clip in anim) {
						animState.Add (clip);
				}
		}

		// Use this for initialization
		void Start ()
		{
				i = 0;
				anim.Play (animState [i].name);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnGUI ()
		{
				if (GUI.Button (new Rect (50, 50, 100, 100), "Change Action")) {
						if (i < animState.Count - 1) {
								i++;
						} else {
								i = 0;
						}
						anim.Play (animState [i].name);
				}
		}
}
