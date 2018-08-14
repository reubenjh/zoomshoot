using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {
	[SerializeField] float xMps = 1f;
	private float xMove;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalThrow = CrossPlatformInputManager.GetAxis("Horizontal");
		xMove = horizontalThrow * xMps;
		print(xMove);
	}
}
