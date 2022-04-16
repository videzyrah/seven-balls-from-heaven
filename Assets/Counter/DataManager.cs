using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
	//DataManager  i.e. ScoreManager For Seven Balls From Heaven 
   public static DataManager Instance;
   
   public int totalScore;
   
   
   private void Awake()
   {
	   
	   if(Instance != null)
	   {
		   Destroy(gameObject);
		   return;
	   } 
	   Instance = this;
	   DontDestroyOnLoad(gameObject);
   }
}
