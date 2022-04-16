using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public Text welcomeText;
	public Text CounterText;
	public Text TotalScoreText;
	public Text finalScoreText;
	
	
	public Button nextStageButton;
	
	private int score;
	public GameObject inputField;
	
	
    // Start is called before the first frame update
    void Start()
    {
		TotalScoreText.text = "Total Score is: " + DataManager.Instance.totalScore;
		//inputField  = GameObject.Find("InputField");
		inputField.gameObject.SetActive(false);
        welcomeText.gameObject.SetActive(true);
		finalScoreText.gameObject.SetActive(false);
		nextStageButton.gameObject.SetActive(false);
		StartCoroutine(PauseForInstructions());
		StartCoroutine(PauseForNextStageButton());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	IEnumerator PauseForInstructions()
	{
		
			yield return new WaitForSeconds(3);
			welcomeText.gameObject.SetActive(false);
	}
	
	IEnumerator PauseForNextStageButton()
	{
		
		yield return new WaitForSeconds(10);
			nextStageButton.gameObject.SetActive(true);		
	}
	
	public void UpdateScore(int scoreToAdd)
	{
		score += scoreToAdd;
		CounterText.text = "Stage Score:" + score;
  		
	}
	
	public void UpdateTotalScore(int scoreToAdd)
	{
		
  		DataManager.Instance.totalScore += scoreToAdd;
		TotalScoreText.text = "Total Score is: " + DataManager.Instance.totalScore;
	}
	
	public void DisplayFinalScore()
	{
		finalScoreText.text = "Final Score is: " + DataManager.Instance.totalScore;
		finalScoreText.gameObject.SetActive(true);
		inputField.gameObject.SetActive(true);
  		
	}
	
	
}
