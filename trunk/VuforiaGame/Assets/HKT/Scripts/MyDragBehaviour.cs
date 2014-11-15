using UnityEngine;
using System.Collections;

public class MyDragBehaviour : MonoBehaviour
{
		private float maxPickingDistance = 2000;// increase if needed, depending on your scene size
	
		private Transform pickedObject = null;
	
		// Use this for initialization
		void Start ()
		{
		}
	
		// Update is called once per frame
		void Update ()
		{
				foreach (Touch touch in Input.touches) {
						Debug.Log ("Touching at: " + touch.position);
			
						//Gets the ray at position where the screen is touched
						Ray ray = Camera.main.ScreenPointToRay (touch.position);
			
						if (touch.phase == TouchPhase.Began) {
								Debug.Log ("Touch phase began at: " + touch.position);
				
								RaycastHit hit = new RaycastHit ();
								if (Physics.Raycast (ray, out hit, maxPickingDistance)) { 
										pickedObject = hit.transform;                    
								} else {
										pickedObject = null;
								}
						} else if (touch.phase == TouchPhase.Moved) {
								Debug.Log ("Touch phase Moved");
				
								if (pickedObject != null) {
										Vector2 screenDelta = touch.deltaPosition;
					
										float halfScreenWidth = 0.5f * Screen.width;
										float halfScreenHeight = 0.5f * Screen.height;
					
										float dx = screenDelta.x / halfScreenWidth;
										float dy = screenDelta.y / halfScreenHeight;
					
										Vector3 objectToCamera = 
						pickedObject.transform.position - Camera.main.transform.position;
										float distance = objectToCamera.magnitude;
					
										float fovRad = Camera.main.fieldOfView * Mathf.Deg2Rad;
										float motionScale = distance * Mathf.Tan (fovRad / 2);
					
										Vector3 translationInCameraRef = 
						new Vector3 (motionScale * dx, motionScale * dy, 0);
					
										Vector3 translationInWorldRef =
						Camera.main.transform.TransformDirection (translationInCameraRef);
					
										pickedObject.position += translationInWorldRef;
								}
						} else if (touch.phase == TouchPhase.Ended) {
								Debug.Log ("Touch phase Ended");
				
								pickedObject = null;
						}
				}
		}
}