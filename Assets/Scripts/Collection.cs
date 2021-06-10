using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collection : MonoBehaviour
{
    public TextMeshProUGUI score;
    [HideInInspector]
    public int points=0;
    private GameObject[] collectibles;
    private GameObject[] nonCollectibles;

    // Start is called before the first frame update
    void Start()
    {
        ViewScore();
    }
    
    void ViewScore()
    {
        score.text = "Score: " + points;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "Collectible")
        {
            points++;   
        }
        else if(collision.tag == "NonCollectible")
        {
            points--;
        }
        ViewScore();
        Destroy(collision.gameObject);
    }
}
