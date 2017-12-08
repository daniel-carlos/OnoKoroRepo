using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AburaAkago : MonoBehaviour
{
	public ParticleSystem particles;
	public Voador pers;

	// Use this for initialization
	void Start ()
	{
		pers = GetComponent<Voador> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Transform player = GameObject.FindWithTag ("Player").transform;
		if (player != null) {
			pers.PosicionarAlvo (player.position);
		}
	}

	public void Spawn ()
	{
		particles.Emit (200);

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		//if(col.tag == "Player"){}
	}
}
