using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuBack : MonoBehaviour
{
    [SerializeField] Button Button;
    void Start()
    {

    }
    public void OnButtonClick()
    {
        SceneManager.LoadScene(0);
    }
}
