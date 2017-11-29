using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_GC_Setup : FSM_Estado
{
	public override void Entrar (FSM fsm)
	{
		fsm.GetComponent<GameController> ().CriarPlayer ();
	}

	public override void Executar (FSM fsm)
	{
		throw new System.NotImplementedException ();
	}

	public override void Sair (FSM fsm)
	{
		throw new System.NotImplementedException ();
	}
}
