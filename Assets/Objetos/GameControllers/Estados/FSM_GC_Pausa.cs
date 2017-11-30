using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_GC_Pausa : GC_Estado
{
	public override void Entrar (FSM fsm)
	{
		Time.timeScale = 0f;
	}

	public override void Executar (FSM fsm)
	{
		
	}

	public override void Sair (FSM fsm)
	{
	
	}
}
