using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public GameObject mainPanelScreen;
    public GameObject optionsScreen;
    public GameObject brics;
    public Text bestScoreText;
    public int BestScore
    {
        get { return PlayerPrefs.GetInt("HighScore", 0); }
        set { PlayerPrefs.SetInt("HighScore", value); PlayerPrefs.Save(); }
    }
    private int playerScore;
    public int PlayerScore
    {
        get { return playerScore; }
        set
        {
            playerScore = value;
            if (BestScore < playerScore)
            {
                BestScore = playerScore;
            }
        }
    }

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        bestScoreText.text = DataManager.Instance.BestScore.ToString();
    }

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
