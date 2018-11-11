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
	public ParticleSystem explosionsGameObject;
	private float timeElapsed = 0.0f;
	private Canvas canvas;
	public Text timeText;
	

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
    	//fireworksGameObject.Stop();
    	//explosionsGameObject.Stop();
    }

 	void Explode( ParticleSystem exp ) {
        exp.Play();
    }
	
	// Update is called once per frame
	void Update () {

		if (!AllFound()){
			timeElapsed += Time.deltaTime;
		} else if (!fireworksGameObject.isPlaying || !explosionsGameObject.isPlaying) {
			fireworksGameObject.Play(true);
			explosionsGameObject.Play(true);
			Debug.Log("was not playing, is playing now");
		} else {
			Debug.Log("was playing");
			
		}

        TimeSpan time = TimeSpan.FromSeconds(Mathf.RoundToInt(timeElapsed));
        timeText.text = ("TIME: " + time.ToString());
	}
}
