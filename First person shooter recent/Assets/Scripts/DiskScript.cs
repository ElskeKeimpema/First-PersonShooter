using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiskScript : MonoBehaviour {

	//   public Rigidbody grenade;
	//   public float throwpower = 10f;
	//    public Rigidbody clone;
	// Use this for initialization

	public float thrust = 10f ;
	public Rigidbody rb;
	public int ammoDiskrifle = 100;
	public Text ammoDiskrifleText;
	public Transform originalObject;
	public Transform reflectedObject;
	//public RaycastHit hit;

	void Start() {
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.forward * thrust,ForceMode.Impulse);   
	}

	// Update is called once per frame

	void FixedUpdate()
	{
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 2)) {
			if (hit.collider.tag == "Enemy") {
				hit.transform.SendMessage ("DoDamage", SendMessageOptions.DontRequireReceiver);
			} else {
				transform.rotation = Quaternion.LookRotation (Vector3.Reflect (transform.forward, hit.normal));
				//reflectedObject.position = Vector3.Reflect (transform.forward,hit.normal);
			}
			Destroy (gameObject, 10.0f);
		}
	}

		//Line.enabled = false; 

		//	yield return new WaitForSeconds (5);
}
	//void FixedUpdate()
	//{
		//if (gameObject.tag != "Enemy")
		//reflectedObject.position = Vector3.Reflect(originalObject.position, Vector3.right);
		//Destroy (gameObject, 10.0f);
		//  if (Input.GetButtonDown("Fire1"))
		//  {
		//  clone = new Vector3(grenade, transform.position += transform.forward * Time.deltaTime * 10);
		//   }

		//}


//https://www.youtube.com/watch?v=Q7LJjAklbfM 2:00
//https://unity3d.com/learn/tutorials/temas/multiplayer-networking/shooting-single-player