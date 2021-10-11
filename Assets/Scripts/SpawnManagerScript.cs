using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{

    public GameObject bricksPrefab;
    public GameObject playerPrefab;
    public GameObject superBricksPrefab;

    Vector3 screenBounds;

    void Awake()
    {               
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        SpawnRandomBrics();
        if (Random.Range(1,5) < 2)
        {
            SpawnSuperBrics();
        }
    }

    void FixedUpdate()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    void SpawnRandomBrics()
    {
 
       for (int i = 0; i < 5; i++)
       {
         int y = i * 3 + 1;
         Instantiate(bricksPrefab, new Vector3(Random.Range(-screenBounds.x + 0.3f, screenBounds.x - 0.3f), playerPrefab.transform.position.y + y), bricksPrefab.transform.rotation);
       }        

    }
    void SpawnSuperBrics()
    {
        for (int i = 0; i < 1; i++)
        {
            int y = Random.Range(1, 3);
            Instantiate(superBricksPrefab, new Vector3(Random.Range(-screenBounds.x + 0.3f, screenBounds.x - 0.3f), playerPrefab.transform.position.y + y), superBricksPrefab.transform.rotation);

        }

    }
}
