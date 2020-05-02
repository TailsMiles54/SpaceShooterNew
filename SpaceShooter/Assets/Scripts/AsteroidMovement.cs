using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

public class AsteroidMovement : MonoBehaviour //движение астероида
{
    public float AsteroidSpeed;
    private UIController ASAS;

    void Start()
    {
        ASAS = GameObject.Find("TopPanel").GetComponent<UIController>();
        //AsteroidSpeed = PlayerPrefs.GetInt("CurDif"); //можно юзать для увеличения скорости врага исходя из выбранного уровня
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Vector2.down * (AsteroidSpeed/4),ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            ASAS.PlayerDamaged();
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Bullet")
        {
            ASAS.EnemyKilled();
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
    
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
