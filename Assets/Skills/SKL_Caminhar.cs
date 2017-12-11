using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKL_Caminhar : Skill_Disparador
{
	public float walkSpeed = 1f;
	public Animator anim;
	public int cont = 0;
	public ControlePersonagem pers;

	public override void FireSkill ()
	{
		cont = 1;
	}

	void LateUpdate ()
	{
		if (cont > 0) {
			anim.SetFloat ("movimento", walkSpeed);
		} else {
			anim.SetFloat ("movimento", 0);
		}
		cont--;
	}
}
