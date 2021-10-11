using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class InGameScript : MonoBehaviour
{
    public GameObject player;
    public GameObject restartButton;
    public GameObject gameOverText;
    public GameObject pauseScreen;

    void Update()
    {
        if (player.GetComponent<PlayerController>().isGameOver == true)
        {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
        }
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void PauseButtton()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0;
    }
    public void PauseToPlayButton()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
