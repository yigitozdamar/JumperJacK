using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    Vector3 screenBounds;

    private void FixedUpdate()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        if (transform.position.y < screenBounds.y -12)
        {
            transform.position = new Vector3(Random.Range(-screenBounds.x + 0.3f, screenBounds.x - 0.3f), screenBounds.y + 3, 0);
            
        }
    }
 
}
