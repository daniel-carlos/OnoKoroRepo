using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_GC_Setup : GC_Estado
{
	public FSM_Estado proximoEstado;

	public override void Entrar (FSM fsm)
	{
		Debug.Log ("Iniciando setup da fase");
		this.gc = fsm.GetComponent<GameController> ();
		this.gc.CriarPlayer ();
		//gc.CriarBanner ();
	}

	public override void Executar (FSM fsm)
	{
		fsm.MudarEstado (proximoEstado);
	}

	public override void Sair (FSM fsm)
	{
		Debug.Log ("Setup da fase finalizado");
	}
}
