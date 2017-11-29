using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

	public Damage damage;

	[Tooltip ("Tags com as quais esse projétil irá colidir")]
	public string tags;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void Lancar (Vector2 direcao)
	{
		GetComponent<Rigidbody2D> ().velocity = direcao;
	}
}
