using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class timeScale : MonoBehaviour
{
    public GameObject rightHandReference;
    // Start is called before the first frame update
    private Vector3 startPosition;
    private Vector3 current;
    public float movedDistance;
    float threshold = 0.01f;

    public float smoothFactor = 0.1f; // Controls the smoothness of the transition
    public float minimumTimeScale = 0.1f; // Minimum time scale when there is no movement
    public float baseMovementSpeed = 5f; // Base movement speed of the object
    private Vector3 movementDirection = Vector3.forward; // Direction of movement


    void Start()
    {
        startPosition = rightHandReference.transform.position;
    }

   // Create a public reference to the hand controller object 
// so you can manually connect them


void Update() {
    // Your existing time scale logic
    current = rightHandReference.transform.position;
    movedDistance = Vector3.Distance(startPosition, current);

    // Target time scale calculation
    float targetTimeScale;
    if (movedDistance < 0.01f) {
        targetTimeScale = minimumTimeScale;
    } else {
        targetTimeScale = Mathf.Clamp(threshold + (movedDistance * 400f), threshold, 1f);
    }

    // Smoothly adjust the current time scale towards the target time scale
    Time.timeScale += (targetTimeScale - Time.timeScale) * smoothFactor;

    // Update the start position for the next frame
    startPosition = current;

    // Update object positions independently
    float movementSpeed = baseMovementSpeed * Time.timeScale;
    transform.position += movementDirection * movementSpeed * Time.unscaledDeltaTime;
}


}
