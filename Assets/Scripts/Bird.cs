using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

public SpawnTruskawka truskawkaPrzesun;
private Rigidbody2D RB ;
public bool isDead = false;	
private Animator animator;
	// Use this for initialization
	void Start () {
	RB = GetComponent<Rigidbody2D>();	
	animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			
			RB.velocity = Vector2.zero; //Vector2(0, 0)
			RB.velocity = new Vector2(0,2.9f);
			//animator.SetTrigger("Fly02");
		}
	}

	 	 void OnCollisionEnter2D(Collision2D other)
		 {
			 isDead = true;	
			animator.SetTrigger("Dead"); 

			
		// NazwaKlasy  .  nazwa zmiennej . funkcja
			GameControls.Instance.BirdDieChangeTextonScreen();
		 // 
		}

		void OnTriggerEnter2D(Collider2D other)
	{
		 if(other.tag=="przeszkoda")  GameControls.Instance.BirdScore(); //przeleciales pomiedzy rurami
		
		if(other.tag=="Truskawka"){
		truskawkaPrzesun.truskawkaMovePosition();
		GameControls.Instance.BirdScore();//przeleciales pomiedzy truskawkami
		}
				if(other.tag=="killer") {

					isDead = true;	
			animator.SetTrigger("Dead"); 

			
		// NazwaKlasy  .  nazwa zmiennej . funkcja
			GameControls.Instance.BirdDieChangeTextonScreen();
				}

		//Debug.Log("SCORE");
	}
}