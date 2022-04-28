using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D RBKiller;
	private float height = 3.0f;
	private float xKiller = 8.0f;
	private int pobranyScore = 0;
	int licznikZmianyScore=0;
	void Start () {
		RBKiller.velocity = new Vector2(0,0);
		RBKiller.transform.position = new Vector2(15,0);
		//StartCoroutine(RunBirdFast(2.0f));

	}
	
	// Update is called once per frame
	void Update () {
      /* 
		float newY = Mathf.Sin( Time.time * 2.0f ) * height;
     xKiller-=0.04f;//*Time.time;
	 Vector2 position = new Vector2( xKiller, newY);
     RBKiller.MovePosition( position );

	 Debug.Log(xKiller);

	 if(xKiller <-20.0f) xKiller = 8.0f;
		 if( RBKiller.transform.position.x < -13.0f ) RBKiller.transform.position = new Vector2(10,0);
	
	*/
	if( pobranyScore != GameControls.Instance.score) // punkty sie zmienily czyli gracz zdobyl punkt zwieksz licznik
	{
		pobranyScore = GameControls.Instance.score;   // pobierz score
		licznikZmianyScore++;

	}

		if(licznikZmianyScore > Random.Range(2,6) ) { //ustaw Ptaka po 4 licznikach

		licznikZmianyScore = 0;
		var a = Random.Range(3.0f,-3.0f);
		StartCoroutine(RunBirdFast(a));
	

		} 
			if(RBKiller.transform.position.x < -25.0f)
			{
				RBKiller.velocity = new Vector2(0,0);
				RBKiller.transform.position = new Vector2(18.1f, 0);
			}
	
    
	
	}

	IEnumerator RunBirdFast(float positionOfKiller) {
		RBKiller.transform.position = new Vector2(8.1f, positionOfKiller);
		yield return new WaitForSeconds(1.2f);
		RBKiller.transform.position = new Vector2(8.18f, positionOfKiller);
	    RBKiller.velocity  = new Vector2(  Random.Range(-25 , -40)  ,positionOfKiller);
		

		//yield return new WaitForSeconds(2);
	}

 
	 


}
