using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Healthscript1 : MonoBehaviour {

	public bool isPlayer;
	public int health = 50;
	public Text healthText;
	//public GameObject RB;
	// public GameObject Player;

	void Start ()
	{
		//  Player.SendMessage("DoDamage", SendMessageOptions.RequireReceiver);
	}

	//Update is called once per frame
	//	void Update () {
	void Update()
	{
		if (isPlayer)
		{
			healthText.text = "Health: " + health;
		}
	}

	void DoDamage()
	{
		health--;

		//SendMessage die
		if(health<=0){
			if(isPlayer)
				SendMessage("PlayerDie");
			else
				SendMessage ("EnemyDie");
		}
	}
//	void DoDamageToPlayer()
//	{
//		PlayerHealth--;
//		if (PlayerHealth <= 0)
//		{
//			SendMessage("PlayerDie");
//		}
//	}

	void DoDamageToRigidbody ()
	{

	}
	//   if (health < 0f) 
	//	{
	//		enemyAIscript_.isPlayerAlive = false;
	//		Destroy (gameObject);
	//		SceneManager.LoadScene("start scene");
	//  }
	//	}

	//  void DoDamage()
	//    {
	//  PlayerHealth -= 6;
	//}
}
