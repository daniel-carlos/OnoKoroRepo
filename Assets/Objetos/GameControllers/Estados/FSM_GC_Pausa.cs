using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_GC_Pausa : GC_Estado
{
	public GameObject menuPausa;
	public GC_Estado estadoNormal;

	public override void Entrar (FSM fsm)
	{
		Time.timeScale = 0f;
		menuPausa.SetActive (true);
		gc.ControlarPersonagem (false);
	}

	public override void Executar (FSM fsm)
	{
		if (Input.GetButtonDown ("Cancel")) {
			fsm.MudarEstado (estadoNormal);
		}
	}

	public override void Sair (FSM fsm)
	{
		menuPausa.SetActive (false);
	}
}
