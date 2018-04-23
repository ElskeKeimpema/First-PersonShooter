using UnityEngine;
using System.Collections;

public class enemyAIscript_ : MonoBehaviour {

	public GameObject Player;
	//public Transform PlayerT;
	public float PlayerDistance;
	public float RotationDamping;
	public float MoveSpeed;
	public static bool IsPlayerAlive = true;
	//Shooting
	public GameObject rocket;
	public GameObject bulletEmitter;
	public float bulletForwardForce;
	//Timer
	public float timerShooting = 5.0f;
	// 1  Healthscript1 Healtscript1 = GetComponent 
	// public GameObject Player;
	// Use this for initialization
	// MyScript myScript = GetComponent(typeof(MyScript)) as MyScript;

	void Start() {

	}

	//Update is called once per frame
	void Update()
	{
		timerShooting -= Time.deltaTime;
		if (timerShooting <= 0.0f) 
		{
			GameObject temporaryBulletHandler = Instantiate (rocket, bulletEmitter.transform.position, bulletEmitter.transform.rotation);
			timerShooting = 5.0f;
		}
	}

		/*if (IsPlayerAlive)
		{ 
			   PlayerDistance = Vector3.Distance(Player.position, transform.position);
		}

		if (PlayerDistance < 15.0f)
		{
			lookAtPlayer();
		}
		if (PlayerDistance < 12.0f)
		{

			if (PlayerDistance > 2.0f)
			{
				Chase();
			}
			// }
			if (PlayerDistance < 10.0f)
			{
				Attack();
			}
		}
	}
	void lookAtPlayer()
	{
		//Quaternion rotation = Quaternion.LookRotation (Player.position = transform.position);
		//transform.rotation = Quaternion.Slerp(transform.rotation,rotation, Time.deltaTime * RotationDamping);
	}

	void Chase()
	{
		transform.Translate (Vector3.forward * MoveSpeed * Time.deltaTime);
	}

	void Attack()
	{
		//		RaycastHit hit;
		//            if (Physics.Raycast(transform.position, transform.forward, out hit))
		//            { 
		//                if (hit.collider.gameObject.tag == "Player")
		//                {
		//                    //hit.collider.gameObject.GetComponent<Healthscript1>().health -= 5f;
		//                  //  Player.SendMessage("DoDamage");
		//                    // myScript.MyFunction;
		//                }
	}*/
	void EnemyDie()
	{
		Player_control.killedEnemies++;
		Destroy(gameObject);
	}
}


// 1. http://answers.unity3d.com/questions/16290/how-do-i-specify-a-receiver-for-a-send-message-fun.html 