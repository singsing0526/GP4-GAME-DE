using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

	void Update () {
		if (Input.GetButtonDown("Submit")) {
			SceneManager.LoadScene("main");
		}
	}
}


