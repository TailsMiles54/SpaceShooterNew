using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class AsteroidMovement : MonoBehaviour
{
    public float AsteroidSpeed;
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Vector2.down * (AsteroidSpeed/4),ForceMode.VelocityChange);
    }
}
