using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GodScript : MonoBehaviour {

	public DefaultTrackableEventHandler cpu;
	public DefaultTrackableEventHandler motherBoard;
	public DefaultTrackableEventHandler ram;
	public DefaultTrackableEventHandler fan;
	public ParticleSystem fireworksGameObject;
	private ParticleSystem fireworksPS;
	private float timeElapsed = 0.0f;
	private Canvas canvas;
	public Text timeText;

	// private bool test;
	
	bool AllFound() {
		List<bool> allFound = new List<bool>{cpu.detected, motherBoard.detected, ram.detected, fan.detected };
		foreach ( bool det in allFound ) {
			if (!det) {
				return false;
			}
		}
		return true;

	}

	void Start()
    {
		fireworksPS = fireworksGameObject.GetComponent<ParticleSystem>();
    }

 	void Explode( ParticleSystem exp ) {
        exp.Play();
    }
	
	// Update is called once per frame
	void Update () {
		if (!AllFound()) {
			timeElapsed += Time.deltaTime;
		} else if (!fireworksGameObject.isPlaying) {
			fireworksGameObject.Play(true);
			StartCoroutine(WaitAndStopFireworks());
			Debug.Log("was not playing, is playing now");
		}

		// if (!test) {
		// 	fireworksGameObject.Play();
		// 	StartCoroutine(WaitAndStopFireworks());
		// 	Debug.Log("was not playing, is playing now");
		// 	test = true;
		// }

        TimeSpan time = TimeSpan.FromSeconds(Mathf.RoundToInt(timeElapsed));
        timeText.text = ("TIME: " + time.ToString());
	}

	IEnumerator WaitAndStopFireworks() {
		Debug.Log("coro");
		yield return new WaitForSeconds(5);
		Debug.Log("stop");
		fireworksGameObject.Stop(true, ParticleSystemStopBehavior.StopEmitting);
	}
}
