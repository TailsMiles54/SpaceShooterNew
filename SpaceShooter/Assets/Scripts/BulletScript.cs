using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletspeed = 1f;
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Vector2.up * bulletspeed,ForceMode.VelocityChange);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
// движение пули
