using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Projetil : Skill
{
	public Animator anim;
	public Projectile shourikenPrefab;
	public Transform spawnPoint;
	public float speed = 3f;
	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}

	protected override void FireSkill ()
	{
		anim.SetFloat ("tipo_ataque", 1f);
		anim.SetTrigger ("ataque");

		Projectile shouriken = Instantiate (shourikenPrefab, spawnPoint.position, spawnPoint.rotation);
		shouriken.Lancar (spawnPoint.right * speed);
	}
}
