using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Weaponswitch : MonoBehaviour {

	public GameObject Weapon01;
	public GameObject Weapon02;
	public GameObject Weapon03;
	public Text Weapon;
//	public Text ammoText;
//	public int ammo = 0;

	void Start()
	{
		Weapon01.SetActive(true);
		Weapon02.SetActive(false);
		Weapon03.SetActive(false);
		Weapon.text = "Weapon: Beamrifle";
	}

	// Update is called once per frame
	void Update () {

		//Weapon.text = "Health:"+ playerHealth; 
		if (Input.GetKeyDown(KeyCode.Q))
		{
			Debug.Log ("test");
			switchWeaponsPlease();
		}

		//if (weapon01 == true) 
		//{
		//	Weapon.text = "Beamrifle";
		//}

		//	if (weapon01 == false) 
		//	{
		//		Weapon.text = "Rocketlauncher";
		//	}

		//	if (weapon03 == true) 
		//	{
		//		Weapon.text = "Diskrifle";
		//	}
	}
	void switchWeaponsPlease()
	{
		if (Weapon01.activeSelf)
		{
			Weapon01.SetActive(false);
			Weapon02.SetActive(true);
			Weapon.text = "Weapon: Rocketlauncher";
		}

		else if (Weapon02.activeSelf)
		{
			Weapon02.SetActive(false);
			Weapon03.SetActive(true);
			Weapon.text = "Weapon: Diskrifle";

		}

		else if (Weapon03.activeSelf)
		{
			Weapon03.SetActive(false);
			Weapon01.SetActive(true);
			Weapon.text = "Weapon: Beamrifle";
		//	ammo = 75;
		//	ammoText.text = "Ammo:"+ ammo;
		}

		else
		{
			Weapon01.SetActive(true);
			Weapon02.SetActive(false);
			Weapon.text = "Weapon: Beamrifle";
		//	ammo = 75;
		//	ammoText.text = "Ammo:"+ ammo;
		}


	}
}
//https://www.youtube.com/watch?v=_MNr8UEC248