using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKR_Cooldown :  Skill_Requisito
{
	public float cooldown = 2;
	float cont;
	// Use this for initialization
	void Start ()
	{
		cont = cooldown;
	}
	
	// Update is called once per frame
	void Update ()
	{
		cont -= Time.deltaTime;
	}


	public override bool Passar ()
	{
		return cont <= 0;
	}

	public override void Erro ()
	{
		
	}

	public override void Sucesso ()
	{
		cont = cooldown;
	}
}
