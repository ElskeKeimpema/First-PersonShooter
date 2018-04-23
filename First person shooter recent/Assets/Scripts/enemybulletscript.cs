using UnityEngine;
using System.Collections;

public class enemybulletscript : MonoBehaviour {
	public float thrust = 10f ;
	public Rigidbody rb;
	public Vector3 center;
	public float radius;

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
			if (hit.collider.tag == "Player") {
				hit.transform.SendMessage ("DoDamage", SendMessageOptions.DontRequireReceiver);
			} else {
				transform.rotation = Quaternion.LookRotation (Vector3.Reflect (transform.forward, hit.normal));
				//reflectedObject.position = Vector3.Reflect (transform.forward,hit.normal);
			}
		}

	}



	//	void OnCollisionEnter()
	//	{
	//		Destroy (gameObject);
	//	}
}

// Use this for initialization
//	void Start () {

//	}

// Update is called once per frame
//	void Update () {

//	}

// https://unity3d.com/learn/tutorials/topics/multiplayer-networking/player-health-single-player
//}
