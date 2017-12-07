using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

	public Damage damage;

	[Tooltip ("Tags que destruirão esse projétil")]
	public string tagsDestroy;
	[Tooltip ("Tags que esse projétil causará dano")]
	public string tagsDamage;

	[Tooltip ("Tempo de vida do projétil")]
	public float lifetime = 10f;
	// Use this for initialization
	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void Lancar (Vector2 direcao)
	{
		GetComponent<Rigidbody2D> ().velocity = direcao;
	}

	public void OnTriggerEnter2D (Collider2D col)
	{
		if (tagsDamage.Contains (col.tag)) {
			col.gameObject.GetComponent<IDamageble> ().Damage (damage);
		}
		if (tagsDestroy.Contains (col.tag)) {
			Destroy (gameObject);
		}
	}
}
