using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float posX;
    private float posY;

    public GameObject collectible;
    public GameObject nonCollectible;
    private GameObject player;
    private GameObject clone1;
    private GameObject clone2;

    [HideInInspector]
    public int count=0;
    private float spawnNumber;

    void Start()
    {
        InvokeRepeating("CreateSpawn", 1,2);
        player = GameObject.Find("Player");
    }

    void CreateSpawn()
    {
        posX = Random.Range(-7.6f, 7.6f);
        posY = 5.9f;
        Vector2 position = new Vector2(posX, posY);

        spawnNumber = Random.Range(0f, 1f);

        if(spawnNumber < 0.8f)
        {
            clone1 = (GameObject)Instantiate(collectible, position, Quaternion.identity);
            Destroy(clone1, 2f);
        }
            
        else
        {
            clone2 = (GameObject)Instantiate(nonCollectible, position, Quaternion.identity);
            Destroy(clone2, 2f);
        }
        count++;

    }

    // Update is called once per frame
    void Update()
    {
        if (count == 20)
        {
            CancelInvoke("CreateSpawn");
            GetComponent<GameOver>().finalPoints = player.GetComponent<Collection>().points;
            GetComponent<GameOver>().callingfun();
            
        }      
    }
}
