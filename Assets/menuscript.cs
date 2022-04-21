using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuscript : MonoBehaviour
{
    [SerializeField] GameObject settingsUI;
    [SerializeField] GameObject mainMenuUI;

    public void StartTheGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }


    public void Settings()
    {
        settingsUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void MainMenu()
    {
        mainMenuUI.SetActive(true);
        settingsUI.SetActive(false);
    }

}
