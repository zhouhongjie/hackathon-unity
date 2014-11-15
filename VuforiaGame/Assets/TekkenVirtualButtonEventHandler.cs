using UnityEngine;

public class TekkenVirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
	public GameObject cube;
	public GameObject Sphere;

	/// <summary>
	/// Called when the scene is loaded
	/// </summary>
	void Start() {
		// Search for all Children from this ImageTarget with type VirtualButtonBehaviour
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i) {
			// Register with the virtual buttons TrackableBehaviour
			vbs[i].RegisterEventHandler(this);
			vbs[i].UpdateAreaRectangle();
		}

		cube.SetActive (true);
		Sphere.SetActive (false);
	}
	
	/// <summary>
	/// Called when the virtual button has just been pressed:
	/// </summary>
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		cube.SetActive (false);
		Sphere.SetActive (true);
	}
	
	/// <summary>
	/// Called when the virtual button has just been released:
	/// </summary>
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) { }
}