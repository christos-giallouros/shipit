using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	public GameObject motherboard;
	public float adjustmentX;
	public float adjustmentY;
	public float adjustmentZ;

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
		Vector3 motherboardPosition = motherboard.transform.position;
		float targetPositionX = motherboardPosition.x + adjustmentX;
		float targetPositionY = motherboardPosition.y + adjustmentY;
		float targetPositionZ = motherboardPosition.z + adjustmentZ;
		// set target position
		targetPosition = new Vector3(targetPositionX, targetPositionY, targetPositionZ);
	}

	// Update is called once per frame
	void Update () {
		if (buttonClicked) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, targetPosition, step);
			Debug.Log(targetPosition);
		}
	}

	public void OnButtonClick () {
		// show object
		gameObject.GetComponent<Renderer>().enabled = true;
		buttonClicked = true;
	}
}
