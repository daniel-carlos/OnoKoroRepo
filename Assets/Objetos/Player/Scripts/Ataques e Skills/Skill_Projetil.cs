using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Projetil : Skill
{
	public Animator anim;

	[Header ("Projétil")]
	public Projectile shourikenPrefab;
	public Damage dano;
	public float speed = 3f;

	[Space ()]
	public Transform spawnPoint;



	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}

	protected void FireSkill ()
	{
		anim.SetFloat ("tipo_ataque", 1f);
		anim.SetTrigger ("ataque");

		Projectile shouriken = Instantiate (shourikenPrefab, spawnPoint.position, spawnPoint.rotation);
		shouriken.Lancar (spawnPoint.right * speed);
		shouriken.damage = dano;
	}
}
