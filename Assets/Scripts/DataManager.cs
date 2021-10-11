using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public  Text bestScoreText;
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

    
}
