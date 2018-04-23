using UnityEngine;
using System.Collections;

public class Mouselook : MonoBehaviour {

	public float Looksensitivity = 5f;
	public float YRotation;
	public float CurrentYrotation;
	public float YRotationV;
	public float XRotation;
	//  public float YRotation;
	public float CurrentXRotation;
	public float XRotationV;

	public float LookSmoothDamp = 0.1f;

	// Use this for initialization
	void Start () {

		Cursor.visible = false;

	}

	// Update is called once per frame
	void Update () {

		XRotation -= Input.GetAxis("Mouse Y") * Looksensitivity;
		YRotation += Input.GetAxis("Mouse X") * Looksensitivity;

		transform.localRotation = Quaternion.Euler(XRotation, 0, 0);
		transform.root.rotation = Quaternion.Euler (0,YRotation,0);

		//if (Input.GetKeyDown (KeyCode.E )) 
		//	{
		//Cursor.visible = true;
		//	} 

		//	else  
		//	{
		//		Cursor.visible = false;
		//	}

	}
}
//https://www.youtube.com/watch?v=i03RoqRLGu4