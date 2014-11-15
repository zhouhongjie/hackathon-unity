using UnityEngine;
using System.Collections;

public class PinchZoom : MonoBehaviour
{
		private float scale_factor = 0.02f;   
		private float MAXSCALE = 2.0f, MIN_SCALE = 0.2f; // zoom-in and zoom-out limits
		private Vector2 prevDist = new Vector2 (0, 0);
		private Vector2 curDist = new Vector2 (0, 0);
		private Vector2 midPoint = new Vector2 (0, 0);
		private Vector3 originalPos;

		void Start ()
		{
				originalPos = transform.position;
		}
	
		void Update ()
		{
				scaleAnim ();
		}
		// Following method check multi touch 
		private void scaleAnim ()
		{
				
				if (Input.touchCount == 2 && Input.GetTouch (0).phase == TouchPhase.Moved && Input.GetTouch (1).phase == TouchPhase.Moved) {
						midPoint = new Vector2 (((Input.GetTouch (0).position.x + Input.GetTouch (1).position.x) / 2), ((Input.GetTouch (0).position.y + Input.GetTouch (1).position.y) / 2));
						midPoint = Camera.main.ScreenToWorldPoint (midPoint);
			
						curDist = Input.GetTouch (0).position - Input.GetTouch (1).position; //current distance between finger touches
						prevDist = ((Input.GetTouch (0).position - Input.GetTouch (0).deltaPosition) - (Input.GetTouch (1).position - Input.GetTouch (1).deltaPosition)); //difference in previous locations using delta positions
						float touchDelta = curDist.magnitude - prevDist.magnitude;
						
						// Zoom out
						if (touchDelta > 0) {
								if (transform.localScale.x < MAXSCALE && transform.localScale.y < MAXSCALE) {
										Vector3 scale = new Vector3 (transform.localScale.x + scale_factor, transform.localScale.y + scale_factor, transform.localScale.z + scale_factor);
										scale.x = (scale.x > MAXSCALE) ? MAXSCALE : scale.x;
										scale.y = (scale.y > MAXSCALE) ? MAXSCALE : scale.y;
										transform.localScale = scale;
								}
						}
			//Zoom in
			else if (touchDelta < 0) {
								if (transform.localScale.x > MIN_SCALE && transform.localScale.y > MIN_SCALE) {
										Vector3 scale = new Vector3 (transform.localScale.x + scale_factor * -1, transform.localScale.y + scale_factor * -1, transform.localScale.z + scale_factor * -1);
										scale.x = (scale.x < MIN_SCALE) ? MIN_SCALE : scale.x;
										scale.y = (scale.y < MIN_SCALE) ? MIN_SCALE : scale.y;
										transform.localScale = scale;
								}
						}
				}

		}

}