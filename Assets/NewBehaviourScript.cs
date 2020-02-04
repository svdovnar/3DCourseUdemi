using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization

	[SerializeField] Vector3 movementVector;
	[Range(0, 1)] [SerializeField] float movementFactor;
	Vector3 startingPos;
	
	void Start () 
	{
		startingPos = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 offset = movementVector * movementFactor;
		transform.position = startingPos + offset;
	}
}
