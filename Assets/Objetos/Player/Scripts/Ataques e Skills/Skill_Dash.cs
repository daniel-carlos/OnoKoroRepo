using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Dash : Skill
{
	public Animator anim;

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
		anim.SetFloat ("tipo_ataque", 3f);
		anim.SetTrigger ("ataque");
	}
}
