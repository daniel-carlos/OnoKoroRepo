using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_AtaqueBasico : Skill
{
	public Animator anim;
	public Damage dano;
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
		anim.SetFloat ("tipo_ataque", 0f);
		anim.SetTrigger ("ataque");
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		try {
			col.transform.root.GetComponent<Vida> ().Damage (dano);
		} catch {

		}
	}
}
