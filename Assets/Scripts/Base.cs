﻿using UnityEngine;
using System.Collections;

public class Base : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDeath()
	{
		gameObject.SetActive(false);

		GameManager.status = GameStatus.GameOver;
	}

}
