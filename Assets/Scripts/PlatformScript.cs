using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    private float jumpForce = 10f;
    Vector3 screenBounds;
    public GameObject mainFloor;
    private void FixedUpdate()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        if (transform.position.y < screenBounds.y -12)
        {
            transform.position = new Vector3(Random.Range(-screenBounds.x + 0.3f, screenBounds.x - 0.3f), screenBounds.y + 3, 0);
            mainFloor.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <=0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
            
        }
 
    }
 
}
