using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRb;
    float movement = 0f;
    private float speed = 10.0f;
    Vector3 screenBounds;
    public bool isGameOver = false;

    // Start is called before the first frame update
    void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        isGameOver = false;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        KeyboardController();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        PlayerGameBounds();

    }
    void KeyboardController()
    {
        movement = Input.GetAxis("Horizontal") * speed;
        Vector2 velocity = playerRb.velocity;
        velocity.x = movement;
        playerRb.velocity = velocity;
    }
    void PlayerGameBounds()
    {
        if (transform.position.x < -screenBounds.x - 0.3f)
        {
            transform.position = new Vector3(screenBounds.x, transform.position.y, 0);
        }
        if (transform.position.x > screenBounds.x + 0.3f)
        {
            transform.position = new Vector3(-screenBounds.x, transform.position.y, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="End")
        {
            Time.timeScale = 0;
            isGameOver = true;
        }
    }
}
