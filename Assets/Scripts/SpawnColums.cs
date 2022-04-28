using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnColums : MonoBehaviour {

 
public Rigidbody2D ColumnaToSpawn;


 
private float _myRandom

{
	get { return (Random.Range(-1.5f ,4.3f)); }
	//set { _myRandom = value; }
}

	   

 
 
 Rigidbody2D instancjaA,instancjaB;

	// Use this for initialization
	void Start () {
		  instancjaA = Instantiate(ColumnaToSpawn , new Vector2(8f, _myRandom  ),Quaternion.identity);
	   
	     
	     instancjaA.velocity = new Vector2(-2.0f,0);

		  instancjaB = Instantiate(ColumnaToSpawn , new Vector2(20.0f, _myRandom ),Quaternion.identity);
	     instancjaB.velocity = new Vector2(-2.0f,0);


 
	}
	// Update is called once per frame
	void Update () {
    
	bool koniecGry = GameControls.Instance.gameEnd;
		
	  
		 
		 if(instancjaA.transform.position.x < -19.0f) instancjaA.transform.position = new Vector2 (7f , _myRandom );
		 if(instancjaB.transform.position.x < -13.0f) instancjaB.transform.position = new Vector2 (13.0f , _myRandom  );

       if(GameControls.Instance.score>2 && koniecGry==false)
	   {
	     instancjaA.velocity = SpeedForSpawningObject();
		 instancjaB.velocity = SpeedForSpawningObject();
		Debug.Log( SpeedForSpawningObject() );
	   }	  

	    if(koniecGry) instancjaA.velocity = new Vector2(0,0);
		if(koniecGry) instancjaB.velocity = new Vector2(0,0);


	}

	public Vector2 SpeedForSpawningObject()
	{
		return new Vector2 (  -0.15f* (float)(GameControls.Instance.score+12),0);
	}


}
