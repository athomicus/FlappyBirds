using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columns : MonoBehaviour {

public float speedColumn = -2.0f;
private Rigidbody2D columnsRB;
private GameObject columnsGameObject;
 
void Awake()
{
 columnsRB = GetComponent<Rigidbody2D>();
 columnsGameObject = GetComponent<GameObject>();

}
	// Use this for initialization
	void Start () {
	columnsRB.velocity = new Vector2(speedColumn,0.0f);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(  GameControls.Instance.gameEnd == true )
		{
			speedColumn = -2.0f;

			columnsRB.velocity = new Vector2(0,0);
			Destroy(columnsGameObject);

		}
		if(transform.position.x > -10.0f) Destroy(columnsGameObject);

		//Debug.Log(speedColumn);
	}

	 
	
}
