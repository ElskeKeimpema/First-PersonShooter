using UnityEngine;
using System.Collections;

public class Rocketscript : MonoBehaviour {

	//   public Rigidbody grenade;
	//   public float throwpower = 10f;
	//    public Rigidbody clone;
	// Use this for initialization
	public float thrust = 10.0f ;
	public Rigidbody rb;
	public Vector3 center;
	public float radius;

	public RaycastHit hit;

	void Start() {
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.forward * thrust,ForceMode.Impulse);   
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		ExplosionDamage(center,radius);
		transform.position += transform.forward * Time.deltaTime * 10;
		Destroy (gameObject, 10.0f);
		//  if (Input.GetButtonDown("Fire1"))
		//  {
		//      clone = new Vector3(grenade, transform.position += transform.forward * Time.deltaTime * 10);
		//   }

	}

	void ExplosionDamage(Vector3 center, float radius)
	{
		Collider[] hitCollider = Physics.OverlapSphere (center, radius);
		for(int i =0; i < hitCollider.Length;i++)
		{
			hitCollider [i].SendMessage ("DoDamage",SendMessageOptions.DontRequireReceiver);

		}
	}
}



//https://www.youtube.com/watch?v=Q7LJjAklbfM 2:00
//https://unity3d.com/learn/tutorials/temas/multiplayer-networking/shooting-single-player