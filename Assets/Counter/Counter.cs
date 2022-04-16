using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue;

    private void Start()
    {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
		if (gameObject.tag == other.gameObject.tag)
        {
		  Debug.Log(gameObject.tag + " hit");
          gameManager.UpdateScore(pointValue + 2);
		  gameManager.UpdateTotalScore(pointValue + 2);
        } 
		else {
          gameManager.UpdateScore(pointValue);
		  gameManager.UpdateTotalScore(pointValue);
        }
    }
	
	private void OnTriggerExit(Collider other)
    {
		if (gameObject.tag == other.gameObject.tag)
        {
          gameManager.UpdateScore(-3);
		  gameManager.UpdateTotalScore(-3);
        } 
		else{
        gameManager.UpdateScore(-pointValue);
		gameManager.UpdateTotalScore(-pointValue);
        }
    }
}
