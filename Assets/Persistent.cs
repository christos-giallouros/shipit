using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Persistent : MonoBehaviour {

	private static bool created = false;

	void Awake()
	{
		if (!created)
		{
			DontDestroyOnLoad(this.gameObject);
			created = true;
		}
		else {
			// This returns the GameObject named Hand.
        	GameObject god = GameObject.Find("GOD");
		}
	}
 
}