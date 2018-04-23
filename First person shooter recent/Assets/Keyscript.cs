using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Keyscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        print(other.tag + " " + other.tag);
        if (other.tag == "Level 1 deur")
        {
     //       SceneManager.LoadScene("level2");
        }
    }
}
