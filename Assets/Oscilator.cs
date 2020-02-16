﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilator : MonoBehaviour {

	// Use this for initialization
	[SerializeField] Vector3 movementVector = new Vector3(10f, 10f, 10f);
	[SerializeField] float period = 2; 
	float movementFactor;
	Vector3 startingPos;

	void Start()
	{
		startingPos = transform.position;

	}

	// Update is called once per frame
	void Update()
	{
		if (period <= Mathf.Epsilon) { return; }
		float cycles = Time.time / period;
		const float tau = Mathf.PI * 2;
		float rawSinWave = Mathf.Sin(cycles * tau);
		movementFactor = rawSinWave / 2f + 0.5f ;
		
		Vector3 offset = movementVector * movementFactor;
		transform.position = startingPos + offset;
	}
}
