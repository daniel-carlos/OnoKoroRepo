using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKL_LancarProjetil : Skill_Disparador
{
	public Animator anim;
	public Rigidbody2D proj;

	public override void FireSkill ()
	{
		anim.SetTrigger ("atacar");

	}


}
