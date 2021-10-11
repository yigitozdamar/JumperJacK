using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject mainPanelScreen;
    public GameObject optionsScreen;
    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OptionsButton()
    {
        mainPanelScreen.SetActive(false);
        optionsScreen.SetActive(true);

    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }
    public void MainMenuButton()
    {
        optionsScreen.SetActive(false);
        mainPanelScreen.SetActive(true);
    }
}
