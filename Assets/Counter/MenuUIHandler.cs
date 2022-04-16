using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
	private string input;
	private GameManager gameManager;
	private int nextSceneToLoad;
	
    // Start is called before the first frame update
    void Start()
    {
      gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
      nextSceneToLoad =  SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void LoadNextScene()
	{
		SceneManager.LoadScene(nextSceneToLoad);
		
	}
	
	public void DisplayGameEndUI()
	{
       Debug.Log("Game Over. Final Score: " + DataManager.Instance.totalScore);
	   gameManager.DisplayFinalScore();
	}
	
	
}
