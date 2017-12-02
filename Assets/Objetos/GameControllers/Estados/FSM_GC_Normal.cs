using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_GC_Normal : GC_Estado
{
	public GC_Estado estadoPausa;

	public override void Entrar (FSM fsm)
	{
		Time.timeScale = 1f;
		gc.ControlarPersonagem (true);
	}

	public override void Executar (FSM fsm)
	{
		if (Input.GetButtonDown ("Cancel")) {
			fsm.MudarEstado (estadoPausa);
		}
	}

	public override void Sair (FSM fsm)
	{
		
	}
}
