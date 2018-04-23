using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscRifle : MonoBehaviour {

	public GameObject bulletEmitter;
	//  public GameObject bullet_prefab;
	public GameObject rocket;
	public float bulletForwardForce;
	GameObject temporaryBulletHandler;
	public float speed = 20;
	public int ammoDiscrifle = 75;
	public Text ammoDiscrifleText;
	public float timerShooting = 0.5f;
	public float timerReload = 3.0f;
	bool reloading;

	// Use this for initialization
		void Start () {
		ammoDiscrifleText.text = "Ammo: " + ammoDiscrifle;
		//temporaryRigidBody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update ()
	{
		timerShooting -= Time.deltaTime;
		if (Input.GetMouseButton(0) && ammoDiscrifle > 0 && timerShooting <= 0.0f)
		{
			GameObject temporaryBulletHandler = Instantiate (rocket, bulletEmitter.transform.position, bulletEmitter.transform.rotation);
			ammoDiscrifle--;
			ammoDiscrifleText.text = "Ammo:"+ ammoDiscrifle;
			timerShooting = 0.5f;
		}
		if (ammoDiscrifle <= 0 && Input.GetKeyDown (KeyCode.R))
		{
			//System.Threading.Thread.Sleep (3000);

			if (ammoDiscrifle <= 0 && Input.GetKeyDown (KeyCode.R))
			{
				reloading = true;
				//	System.Threading.Thread.Sleep (3000); 

			}
			if (reloading) {
				timerReload -= Time.deltaTime;
				if (timerReload <= 0.0f) 
				{
					ammoDiscrifle = 75;
					reloading = false;
				}
			}
		}
	}
}




	// Hieronder start het oude script
	//void Start () {
		//temporaryRigidBody = GetComponent<Rigidbody>();
	//}

	// Update is called once per frame
	//void Update () {
	//	if (Input.GetMouseButton(0))
	//    {
	//		temporaryBulletHandler = Instantiate (rocket, bulletEmitter.transform.position, bulletEmitter.transform.rotation) as GameObject;
	//		temporaryBulletHandler.transform.Rotate (Vector3.left * 90);
	//
	//		temporaryRigidBody = temporaryBulletHandler.GetComponent<Rigidbody> ();
	//		temporaryRigidBody.AddForce (transform.forward * bulletForwardForce);
	//		Destroy (temporaryBulletHandler, 10.0f);
	//    }
	//}


	// Update is called once per frame
	//void Update (){
		//	{	if(ammoDiscrifle > 0) 
		//		{
		//			if (Input.GetMouseButton(0))
		//			{
		//						Camera cam = Camera.main;
		//  			GameObject temporaryBulletHandler = Instantiate (rocket, bulletEmitter.transform.position, bulletEmitter.transform.rotation);
		//				ammoDiscrifle--;
		//				ammoDiscrifleText.text = "Ammo:"+ ammoDiscrifle;
		//		rocket.rigidbody.AddForce (cam.transform.forward * bulletForwardForce, ForceMode.Impulse);
		//		temporaryRigidBody.AddForce (bulletEmitter.transform.forward * bulletForwardForce, ForceMode.Force);
		//		Destroy (temporaryBulletHandler, 10.0f);
		//		Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)as Rigidbody;
		//		instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));
		//temporaryBulletHandler.GetComponent<Rigidbody>().AddForce(0, 0, bulletForwardForce, ForceMode.Impulse);
		//}
		//	}
		//		else
		//		{   
		//			
		//			if (Input.GetKeyDown ("r"))
		//			{
		//				//timerReload -= Time.deltaTime;
		//				ammoDiscrifle = 75;
		//				break;
		//			}
		//		}
//		do{
//			if (Input.GetMouseButton(0))
//			{
//				//		Camera cam = Camera.main;
//				GameObject temporaryBulletHandler = Instantiate (rocket, bulletEmitter.transform.position, bulletEmitter.transform.rotation);
//				ammoDiscrifle--;
//				ammoDiscrifleText.text = "Ammo:"+ ammoDiscrifle;
//			}
//		}while(ammoDiscrifle > 0 );
//
//		if (Input.GetKeyDown ("r"))
//		{
//			//timerReload -= Time.deltaTime;
//			ammoDiscrifle = 75;
//
//		}
	//}
//}
