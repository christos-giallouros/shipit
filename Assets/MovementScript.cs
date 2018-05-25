using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

	public float speed = 40f;
	public float targetX = -86.5f;
	public float targetY = 4f;
	public float targetZ = -9.2f;
	private Vector3 targetPosition;

	void Start () {
		targetPosition = new Vector3 (targetX, targetY, targetZ);
	}

	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, targetPosition, step);
	}
}
