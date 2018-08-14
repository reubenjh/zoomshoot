using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {
	[Tooltip("In mps")][SerializeField] float xSpeed = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
		float xOffsetThisFrame = xThrow * xSpeed * Time.deltaTime;
		print(xOffsetThisFrame);
	}
}
