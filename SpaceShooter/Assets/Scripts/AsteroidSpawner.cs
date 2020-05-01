using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject Asteroid;
    public GameObject[] Waypoints;
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy() {
        while (true)
        {
            GameObject Aster = Instantiate(Asteroid);
            Aster.transform.position = Waypoints[Random.Range(0, Waypoints.Length)].transform.position;
            yield return new WaitForSeconds(1f);
        }
    }
}
