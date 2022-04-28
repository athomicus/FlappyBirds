using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {
private  Rigidbody2D rb ;

 //public GameObject prefabTrawy;
 
 
	// Use this for initialization
	void Awake () {
		 
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(-1.5f,0);

		 
	}
	// Update is called once per frame 
	void Update () {  

		if(  GameControls.Instance.gameEnd == true )
		{
			//prefabTrawy.rigidbody2D.velocity = new Vector2(0,0);
			rb.velocity = new Vector2(0,0);

		}

		if( transform.position.x <= -21.27f)
		{

			 transform.position  = new Vector2 (15.55f , transform.position.y );
		}
	}
}
