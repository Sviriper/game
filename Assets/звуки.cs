using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    [SerializeField] GameObject torch;
    [SerializeField] GameObject sword;
    [SerializeField] AudioSource swordSound;
    [SerializeField] AudioSource torchSound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            swordSound.Play();
            sword.SetActive(true);
            torch.SetActive(false);
            torchSound.Stop();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            torchSound.Play();
            sword.SetActive(false);
            torch.SetActive(true);
        }
    }
}

