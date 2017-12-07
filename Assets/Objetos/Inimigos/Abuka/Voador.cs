using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voador : MonoBehaviour
{
	public float speed = 1f;
	public Transform alvo;
	public Vector3 offset;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		


		Mover ();
	}

	public void PosicionarAlvo (Vector3 posicao)
	{
		alvo.position = posicao + offset;

	}

	public void Mover ()
	{
		transform.position = Vector3.Lerp (transform.position, alvo.position, Time.deltaTime * speed / Vector3.Distance (transform.position, alvo.position));
	}
}
