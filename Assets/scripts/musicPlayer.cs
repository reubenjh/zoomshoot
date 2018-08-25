using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicPlayer : MonoBehaviour {

	private void Awake () {
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		Invoke("loadFirstScene", 5f);

	}

	void loadFirstScene() {
		SceneManager.LoadScene(1);
	}
}
