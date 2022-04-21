using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    [SerializeField] GameObject torch;
    [SerializeField] GameObject sword;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sword.SetActive(true);
            torch.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sword.SetActive(false);
            torch.SetActive(true);
        }
    }

}
