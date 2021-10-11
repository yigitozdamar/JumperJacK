using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public Text scoreText;
    public Rigidbody2D playerRb;
    public int topScore = 0;
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (playerRb.velocity.y > 0 && Camera.main.transform.position.y > topScore)
        {
            
            topScore = (int)Camera.main.transform.position.y;
            DataManager.Instance.PlayerScore = (int)topScore;
            
        }
        scoreText.text = topScore.ToString();
    }
}
