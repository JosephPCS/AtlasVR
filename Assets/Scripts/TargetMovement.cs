using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class TargetMovement : MonoBehaviour
{
   Vector3 startPosition;
    public float amplitude = 5f; // How far the target should move from the start position
    public float frequency = 1f; // Speed of the oscillation

void Start() {
	// you will need to store the starting position so your targets don't all jump around
	startPosition = transform.position;
}

void Update() {
	// Calculate the new x position using the Sin function
        float xMovement = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = startPosition + new Vector3(xMovement, 0f, 0f);
}

 private void OnCollisionEnter(Collision other){
        Destroy(gameObject, 1f);
    }
}
