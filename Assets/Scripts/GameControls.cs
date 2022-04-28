using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControls : MonoBehaviour {

	//SINGLETON
 
public static GameControls Instance;

 
 public GameObject textGameOver;
 public TextMesh textScore;

 public TextMesh highSCore;

 public bool gameEnd = false;

public int score = 0;

private int bestScore;
 


void Awake ()
{

highSCore.text = "highScore:" + (PlayerPrefs.GetInt("highScore").ToString());

	//if(PlayerPrefs.HasKey("BestScore")) 	 bestScore = PlayerPrefs.GetInt("BestScore");
	if( Instance == null ) // jesli nie zostala zainicjowana instancja tej klasy to przypisz obiekt tej klasy do instancji
	{
		Instance = this; 
	} else if ( Instance != this ) //jesli instancja nie wskazuje na obiekt tej klasy czyli powstala jest przypisana ale do jakiegos innnego
	{
		 Destroy(this.gameObject);
	}	 


}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gameEnd && Input.GetMouseButtonDown(0) )
		{
			
			
			int currentscene = SceneManager.GetActiveScene().buildIndex;
			SceneManager.LoadScene(currentscene);

		}
	}

	public void BirdDieChangeTextonScreen()
	{
      textGameOver.SetActive(true);
	  
	  gameEnd = true;
	 // PlayerPrefs.SetInt("BestScore", 20);
	 if( PlayerPrefs.GetInt("highScore") < score)
	 { 
		 PlayerPrefs.SetInt("highScore",score);
	 }
	 
	}




public void BirdScore()
{
	score++;
	textScore.text  = "Score: " + score.ToString() ;
}

}



/*

sposób 

public class SomeClass : MonoBehaviour {
    private static SomeClass _instance;

    public static SomeClass Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }
}

 */
