using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKL_Pular : Skill_Disparador
{
	public Rigidbody2D rb;
	public Animator anim;
	public float jump = 5f;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public override void FireSkill ()
	{
		Vector2 vel = rb.velocity;
		vel.y = jump;
		rb.velocity = vel;
		anim.SetTrigger ("pular");
	}
}
