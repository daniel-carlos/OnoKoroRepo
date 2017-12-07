using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_GC_Eciclopedia : GC_Estado
{
	public GameObject telaCompendio;
	public GC_Estado pausa;

	public void Voltar ()
	{
		
	}

	public override void Entrar (FSM fsm)
	{
		telaCompendio.SetActive (true);
	}

	public override void Executar (FSM fsm)
	{
		if (Input.GetButtonDown ("Cancel")) {
			fsm.MudarEstado (pausa);
		}
	}

	public override void Sair (FSM fsm)
	{
		telaCompendio.SetActive (false);
	}
}
