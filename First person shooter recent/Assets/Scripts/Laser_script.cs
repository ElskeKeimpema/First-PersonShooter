using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Laser_script : MonoBehaviour {

	// Use this for initialization

	LineRenderer Line;
	public float timerFireLaser = 0.003F;
	public int ammoBeamrifle = 100; 
	public Text ammoBeamrifleText;
	public int PlayerHealth = 50;
	public int enemyHealth = 25;
	public Text HealthText;
	public float timerShooting = 0.5f;
	public float timerReload = 3.0f;
	bool reloading;

	void Start ()
	{
		Line = gameObject.GetComponent<LineRenderer>();
		Line.enabled = false;
		//	Screen.lockCursor = true;
	}

	// Update is called once per frame

	void Update ()
	{
		HealthText.text = "Health: " + PlayerHealth;
		ammoBeamrifleText.text = "Ammo: " + ammoBeamrifle;
		FireLaser ();
//		if (Input.GetButtonDown("Fire1"))
//		{
//			//StopCoroutine("FireLaser");
//		//	timerShooting -= Time.deltaTime;
//			//StartCoroutine ("FireLaser");
//	//		System.Threading.Thread.Sleep (5000);
//	//		InvokeRepeating ("StartFireLaser", timerFireLaser, timerFireLaser);
//		}
		if (ammoBeamrifle <= 0)
		{   
				if (ammoBeamrifle <= 0 && Input.GetKeyDown (KeyCode.R))
				{
					reloading = true;
				}
				if (reloading)
				{
					timerReload -= Time.deltaTime;
					if (timerReload <= 0.0f) 
					{
						ammoBeamrifle = 100;
						reloading = false;
					}
				}
			}
		}


	void FireLaser ()
	{   

		if (Input.GetButton ("Fire1") && ammoBeamrifle > 0) { //&& timerShooting <= 0.0f)
			Line.enabled = true;
			//line.renderer.material.mainTextureOffset = new Vector2(0, Time.time);

			//			Renderer ren = line.GetComponent<Renderer> ();
			//			ren.material.mainTexture. = new Vector2 (0, Time.time);
			Ray ray = new Ray (transform.position, transform.forward);
			RaycastHit hit;
			ammoBeamrifle--;
			ammoBeamrifleText.text = "Ammo: " + ammoBeamrifle;

			Line.SetPosition (0, ray.origin);
			if (Physics.Raycast (ray, out hit, 100)) {

				Line.SetPosition (1, hit.point);
				//if (hit.rigidbody)
				//  {
				// hit.rigidbody.SendMessage("DoDamageToRigidbody");
				// hit.rigidbody.AddForceAtPosition(transform.forward * 5, hit.point);
				// }
				if (hit.collider.tag == "Enemy") {
					hit.transform.SendMessage ("DoDamage", SendMessageOptions.DontRequireReceiver);
				}
			}

			Line.SetPosition (1, ray.GetPoint (100));
			//yield return null;
		} else {
			Line.enabled = false; 
		}
		//timerShooting = 0.5f;

	//	yield return new WaitForSeconds (5);
	}
}
//Live Training 6 Nov 2013 - Fun with Lasers