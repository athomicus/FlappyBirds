using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTruskawka : MonoBehaviour {

public Rigidbody2D RBTruskawka;
public SpawnColums SpeedForTruskawka;
	// Use this for initialization
	void Start () {
		RBTruskawka = Instantiate(RBTruskawka,new Vector2(15,3),Quaternion.identity );
		
		RBTruskawka.velocity =    SpeedForTruskawka.SpeedForSpawningObject();
	}
	
	// Update is called once per frame
	void Update () {
		if(RBTruskawka.transform.position.x<-15.0f) truskawkaMovePosition();

		if(GameControls.Instance.gameEnd) RBTruskawka.velocity = new Vector2(0,0);
	}

	public void truskawkaMovePosition()
	{
      int a = Random.Range(1,10);
	  if(a>=6)	 {
		   RBTruskawka.transform.position = new Vector2(15,-2.35f);
	  }
	               else
				   {
					RBTruskawka.transform.position = new Vector2(15,3);   
				   }
	  
	  RBTruskawka.velocity =    SpeedForTruskawka.SpeedForSpawningObject();

	}
}
