using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTN_Cooldown : DT_No
{
	public float cooldown = 2f;
	float tempo = 0f;
	// Use this for initialization
	void Start ()
	{
		tempo = cooldown;
	}
	
	// Update is called once per frame
	void Update ()
	{
		tempo -= Time.deltaTime;
	}

	public override void Ativar ()
	{
		SelectChild (tempo <= 0);
		if (tempo <= 0) {
			tempo = cooldown;
		}
	}
}
