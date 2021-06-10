using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject endScreen;
    public TextMeshProUGUI finalScore;
    [HideInInspector]
    public int finalPoints;
    private GameObject player;

    private void Start()
    {
        endScreen.SetActive(false);
        player = GameObject.Find("Player");
    }

    public void callingfun()
    {
        Invoke("GameEnd", 2f);
    }
    public void GameEnd()
    {
        player.SetActive(false);
        player.GetComponent<Collection>().score.enabled = false;
        endScreen.SetActive(true);
        finalScore.text = "Final points: " + finalPoints;
    }
}
