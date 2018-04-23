using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Rocketlauncer_script : MonoBehaviour
{
	public GameObject bulletEmitter;
	public GameObject rocket;
	public float bulletForwardForce;
	GameObject temporaryBulletHandler;
	public float speed = 20;
	public int ammoRocketlauncher = 50;
	public Text ammoRocketlauncherText;
	public float timerShooting = 0.5f;
	public float timerReload = 3.0f;
	bool reloading;
	// Use this for initialization
	void Start () {
		ammoRocketlauncherText.text = "Ammo: " + ammoRocketlauncher;
		//temporaryRigidBody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update ()
	{	
		timerShooting -= Time.deltaTime;
		if (Input.GetMouseButton(0) && ammoRocketlauncher > 0 && timerShooting <= 0.0f)
		{
			GameObject temporaryBulletHandler = Instantiate (rocket, bulletEmitter.transform.position, bulletEmitter.transform.rotation);
			ammoRocketlauncher--;
			ammoRocketlauncherText.text = "Ammo:"+ ammoRocketlauncher;
			timerShooting = 0.5f;
		}
		if (ammoRocketlauncher <= 0 && Input.GetKeyDown (KeyCode.R))
		{
			reloading = true;
		//	System.Threading.Thread.Sleep (3000); 

		}
		if (reloading) {
			timerReload -= Time.deltaTime;
			if (timerReload <= 0.0f) 
			{
				ammoRocketlauncher = 50;
				reloading = false;
			}
		}
	}
}
