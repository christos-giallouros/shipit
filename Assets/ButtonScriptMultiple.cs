using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScriptMultiple : MonoBehaviour {

	public float targetX;
	public float targetY;
	public float targetZ;

	private float speed = 40;
	private Vector3 targetPosition;
	private bool buttonClicked = false;

	// Use this for initialization
	void Start () {
		// hide object
		Renderer[] children = GetComponentsInChildren<Renderer> ();
		foreach (var c in children) {
			c.enabled = false;
		}

		// set target position
		targetPosition = new Vector3 (targetX, targetY, targetZ);
	}
	
	// Update is called once per frame
	void Update () {
		if (buttonClicked) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, targetPosition, step);
		}
	}

	public void OnButtonClick () {
		// show object
		Renderer[] children = GetComponentsInChildren<Renderer> ();
		foreach (var c in children) {
			c.enabled = true;
		}
		buttonClicked = true;
	}
}
