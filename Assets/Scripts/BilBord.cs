using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilBord : MonoBehaviour
{
    [SerializeField] Transform mainPlayerCam;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + mainPlayerCam.forward);
    }

}
