using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKL_Atacar : Skill_Disparador
{
	public Animator anim;

	public override void FireSkill ()
	{
		anim.SetTrigger ("atacar");
	}


}
