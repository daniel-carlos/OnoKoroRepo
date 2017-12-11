using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTA_Virar : DT_No
{

	public ControlePersonagem pers;
	public Skill caminhar;

	void Start ()
	{
		pers.SetDirecao (1);
	}

	public override void Ativar ()
	{
		if (pers == null) {
			pers = GetComponentInParent<ControlePersonagem> ();
		}

		pers.SetDirecao (-pers.direcao);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
