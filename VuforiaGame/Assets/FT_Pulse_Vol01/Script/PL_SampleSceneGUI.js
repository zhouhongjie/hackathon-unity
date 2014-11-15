var mySkin : GUISkin;
var effect01 : GameObject;
var effect02 : GameObject;
var effect03 : GameObject;
var effect04 : GameObject;
var effect05 : GameObject;
var effect06 : GameObject;
var effect07 : GameObject;

function OnGUI ()
{
	GUI.skin = mySkin;
	
	GUI.Label (Rect (70,10,200,30), "FT_Pulse_Vol01");

	if(GUI.Button (Rect (10,40,20,20), GUIContent ("", "BlueClinderFX")))
	{	Instantiate(effect01, new Vector3(0, 1.0, 0), Quaternion.Euler(0, 0, 0));	}
	if(GUI.Button (Rect (40,40,20,20), GUIContent ("", "BlueDiscFX")))
	{	Instantiate(effect02, new Vector3(0, 1.0, 0), Quaternion.Euler(0, 0, 0));	}
	if(GUI.Button (Rect (70,40,20,20), GUIContent ("", "BlueDisplayFX")))
	{	Instantiate(effect03, new Vector3(0, 1.0, 0), Quaternion.Euler(0, 0, 0));	}
	if(GUI.Button (Rect (100,40,20,20), GUIContent ("", "GreenDiscFX")))
	{	Instantiate(effect04, new Vector3(0, 1.0, 0), Quaternion.Euler(0, 0, 0));	}
	if(GUI.Button (Rect (130,40,20,20), GUIContent ("", "GreenDisplayFX")))
	{	Instantiate(effect05, new Vector3(0, 1.0, 0), Quaternion.Euler(0, 0, 0));	}
	if(GUI.Button (Rect (160,40,20,20), GUIContent ("", "OrangeDiscFX")))
	{	Instantiate(effect06, new Vector3(0, 1.0, 0), Quaternion.Euler(0, 0, 0));	}
	if(GUI.Button (Rect (190,40,20,20), GUIContent ("", "RedFlareFX")))
	{	Instantiate(effect07, new Vector3(0, 1.0, 0), Quaternion.Euler(0, 0, 0));	}

	GUI.Label (Rect (10,Screen.height-30,200,30), GUI.tooltip);
}