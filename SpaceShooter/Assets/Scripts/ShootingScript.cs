using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class ShootingScript : MonoBehaviour
{
    public float AttackSpeed = 1;
    public GameObject bullet;
    private void Start()
    {
        InvokeRepeating("Shot", 0, AttackSpeed); // вызов выстрела
    }
    void Shot()
    {
        var asdf = Instantiate(bullet);                //спавн снаряда
        asdf.transform.position = gameObject.transform.position;                //спавн снаряда
    }
}
//скрипт создание выстрела
