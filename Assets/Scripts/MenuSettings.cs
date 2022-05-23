using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuSettings : MonoBehaviour
{
    [SerializeField] Button Button;
    void Start()
    {

    }
    public void OnButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}