using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_SaltoDuplo : Skill
{
	bool salto = false;
	public Animator anim;
	public ControlePersonagem pers;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnAterrissagem ()
	{
		salto = false;
		anim.SetFloat ("roll", 0f);
	}

	protected void FireSkill ()
	{
		if (!salto) {
			pers.Jump (true);
			anim.SetFloat ("roll", 1f);

			salto = true;
		}

	}
}
