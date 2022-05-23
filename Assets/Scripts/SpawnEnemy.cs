using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public KeyCode spawnKey = KeyCode.Mouse1;
    public int totalSpawn;

    bool readyToSpawn;
    private void Start()
    {
        readyToSpawn = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(spawnKey) && readyToSpawn && totalSpawn > 0)
        {
            spawn();
        }
    }

    private void spawn()
    {

    }
}
