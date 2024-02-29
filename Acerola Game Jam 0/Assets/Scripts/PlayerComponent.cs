using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComponent : MonoBehaviour
{
    private Rigidbody ownRB;
    public Vector3 movement;
    public float speedMod;
    public static PlayerComponent instance;
    private void Awake()
    {
        ownRB = GetComponent<Rigidbody>();
        instance = this;
    }

    private void Update()
    {
        //Handle Input
        movement.x = Input.GetKey(KeyCode.A) ? -1 : Input.GetKey(KeyCode.D) ? 1 : 0;
        movement.z = Input.GetKey(KeyCode.W) ? 1 : Input.GetKey(KeyCode.S) ? -1 : 0;
        movement.Normalize();
    }

    private void FixedUpdate()
    {
        //Move Player
        ownRB.AddForce(movement * speedMod);
    }
}
