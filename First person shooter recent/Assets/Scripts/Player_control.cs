using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_control : MonoBehaviour
{

	//public GameObject Prefab;
	public float Speed;
	//public Rigidbody RB;
	public CharacterController Player;
	public float Gravity = 9.81f;
	public float JumpSpeed = 10.0F;
	public Text Kills;
	public static int killedEnemies = 0;

	public GameObject RocketPrefab;
	public Transform BulletSpawn;

	// public moveDirection movementplayer;


	//mouselookscript variables
	// public float looksensitivity = 5f;
	//  public float xRotation;
	//   public float yRotation;
	//   public float currentXRotation;
	//   public float xRotationV;
	//public float lookSmoothDamp = 0.1f;

	// Use this for initialization

	// public int playerHealth=30;
	// public Text livetext;
	//int damage=10;
	//  void Start () {
	//	Print(playerHealth);
	//}

	//	void OnCollisionEnter(Collision_collision)
	//	{
	//	if(_collision.gameObject.tag=="EnemyDamage"){
	//		print ("Enemy Just touched something weird. Oh No!")
	//}
	// Update is called once per frame
	void Update()
	{

		Kills.text = "Kills: " + killedEnemies;

		//  CharacterController controller = GetComponent<CharacterController>();
		//RaycastHit hit;

		//Debug.DrawRay (transform.position, transform.forward * 100, Color.red);
		//if (Input.GetKeyDown (KeyCode.Mouse0)) {

		//Nieuwe kogel
		//	Instantiate (prefab, transform.position, transform.rotation);
		//Raycast naar voren met 100 units	
		//	if (Physics.Raycast (transform.position, transform.forward, out hit, 100)) {
		//doet damage aan funciteDoDamage met 4 schade.
		//hit.transform.SendMessage ("DoDamage", 4, SendMessageOptions.DontRequireReceiver);

		//Mouse script
		// xRotation -= Input.GetAxis("Mouse X") * looksensitivity;
		// transform.rotation = Quaternion.Euler (xRotation, yRotation, 0);

		//livetext.text = "playerHealth" + playerHealth;

		//  if (Input.GetKeyDown())
		//  {
		//     Fire();
		//}

		Vector3 moveDirection = Vector3.zero;
		if (Player.isGrounded)
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= Speed;

		}
		if (Input.GetButton("Jump"))
		{
			moveDirection.y = 20;
		}
		// moveDirection.y -= Gravity * Time.deltaTime;
		// controller.Move(moveDirection * Time.deltaTime);

		moveDirection.y -= Gravity * Time.deltaTime;
		Player.Move(moveDirection * Time.deltaTime);

	}

	//  void Fire()
	//  {
	//Create the Rocket from the Rocket Prefab

	// public GameObject = (GameObject)Instantiate(
	//  RocketPrefab,
	//  bulletSpawn.position,
	// bulletSpawn.rotation);

	//   Add velocity to the bullet
	//      Rocketlauncer_script.Getcomponent<Rigidbody>().velocity = bullet.transform.forward * 6;

	//    Destroy the rocket after 2 seconds
	//   Destroy(bullet, 2.0f);


	//  public override void OnStartPlayer()
	//  {
	//     GetComponent<MeshRenderer>().material.color = Color.blue;
	// }

	void OnTriggerEnter(Collider other)
	{
		print(other.name + " " + other.tag);
		if (other.tag == "Level 1 key")
		{
			SceneManager.LoadScene("level 2");
			//other.transform.SetParent (transform);
			//other.transform.GetComponent<BoxCollider> ().isTrigger = false;
		}
		// else if (other.tag == "Level deur 1")
		//  {
		//SceneManager.LoadScene("level2");
		//}

		if (other.tag == "Level 2 key")
		{
			SceneManager.LoadScene("level 3");
		}

		if (other.tag == "Level 3 key")
		{
			SceneManager.LoadScene("level 4");
		}

		if (other.tag == "Level 4 key")
		{
			SceneManager.LoadScene("end scene");
		}

		else if (other.tag == "Level 1 deur")
		{
			SceneManager.LoadScene("start scene");
		}
	}

	void PlayerDie()
	{
		SceneManager.LoadScene("start scene");
	}

	/*void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "ProjectileEnemy") 
		{
			gameObject.SendMessage ("DoDamageToPlayer");
		}

	}*/

}








