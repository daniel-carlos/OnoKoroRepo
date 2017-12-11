using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTA_Andar : DT_No
{
	public ControlePersonagem pers;
	public Skill caminhar;
	public Skill jump;

	public override void Ativar ()
	{
		if (pers == null) {
			pers = GetComponentInParent<ControlePersonagem> ();
		}

		caminhar.TentarDisparo ();
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
