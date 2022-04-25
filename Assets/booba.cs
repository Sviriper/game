using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class booba : MonoBehaviour
{
    public GameObject Wall;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(Wall);
        }
    }
}
