using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenaMenuInicial : MonoBehaviour
{

	public float minDelay = 1f;
	public float maxDelay = 5f;

	// Use this for initialization
	void Start ()
	{
		Invoke ("Relampago", Random.Range (minDelay, maxDelay));
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void Relampago ()
	{
		Animator anim = GetComponent<Animator> ();
		anim.SetTrigger ("relâmpago");

		Invoke ("Relampago", Random.Range (minDelay, maxDelay));
	}
}
