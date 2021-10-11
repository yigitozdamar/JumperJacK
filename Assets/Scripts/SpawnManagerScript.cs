using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{

    public GameObject bricksPrefab;
    public GameObject playerPrefab;
    //float spawnminX = -2.1f;
    //float spawnMaxX = 2.15f;
    //float spawnminY = 2f;
    //float spawnMaxY = 5f;
    Vector3 screenBounds;

    void Awake()
    {               
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        SpawnRandomBrics();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void SpawnRandomBrics()
    {
    /*
       for(int i = 0; i < 5; i++)
       {
       int y = i * 3 + 1;
        Instantiate(bricksPrefab, new Vector3(Random.Range(-screenBounds.x + 0.3f, screenBounds.x - 0.3f),playerPrefab.transform.position.y +y), bricksPrefab.transform.rotation);
       }
      */ 
        Instantiate(bricksPrefab, new Vector3(Random.Range(-screenBounds.x + 0.3f, screenBounds.x - 0.3f),playerPrefab.transform.position.y +1,0), bricksPrefab.transform.rotation);
        Instantiate(bricksPrefab, new Vector3(Random.Range(-screenBounds.x + 0.3f, screenBounds.x - 0.3f),playerPrefab.transform.position.y +4,0), bricksPrefab.transform.rotation);
        Instantiate(bricksPrefab, new Vector3(Random.Range(-screenBounds.x + 0.3f, screenBounds.x - 0.3f),playerPrefab.transform.position.y +7,0), bricksPrefab.transform.rotation);
        Instantiate(bricksPrefab, new Vector3(Random.Range(-screenBounds.x + 0.3f, screenBounds.x - 0.3f),playerPrefab.transform.position.y +10,0), bricksPrefab.transform.rotation);
        Instantiate(bricksPrefab, new Vector3(Random.Range(-screenBounds.x + 0.3f, screenBounds.x - 0.3f),playerPrefab.transform.position.y +13,0), bricksPrefab.transform.rotation);
    }
      

}
