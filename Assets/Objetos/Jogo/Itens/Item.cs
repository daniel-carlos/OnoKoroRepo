using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

	public string valor;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}


	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Player") {
			Destroy (gameObject);
		}
		col.SendMessage ("Coleta", valor, SendMessageOptions.DontRequireReceiver);
		GameObject.FindWithTag ("GameController").GetComponent<GameController> ().OnItemColetado (0);
	}
}
