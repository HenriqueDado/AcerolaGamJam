using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContainer : MonoBehaviour
{
    public GameObject body;
    public float rotationSpeed = 5f; 
    Quaternion targetRotation;

    private void Update()
    {
        // Get the movement vector from the PlayerComponent
        Vector3 movementDirection = -PlayerComponent.instance.movement;

        if (movementDirection!= Vector3.zero)
        {
            targetRotation = Quaternion.LookRotation(movementDirection);
        }
        

        // Smoothly rotate the container towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        this.transform.position = body.transform.position;
    }
}
