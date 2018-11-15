using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	public GameObject motherboard;

	private float targetX;
	private float targetY;
	private float targetZ;

	private float speed = 40;
	private Vector3 targetPosition;
	private bool buttonClicked = false;

	// Use this for initialization
	void Start () {
		// hide object
		gameObject.GetComponent<Renderer>().enabled = false;
		// set target position
		targetPosition = motherboard.transform.position;
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
		gameObject.GetComponent<Renderer>().enabled = true;
		buttonClicked = true;
	}
}
