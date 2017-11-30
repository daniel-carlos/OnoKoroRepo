using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTE_Dano : MonoBehaviour
{

	public Vida vida;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Fire3")) {
			vida.Damage (new Damage (gameObject, Random.Range (10, 30), "OK"));
		}
	}
}
