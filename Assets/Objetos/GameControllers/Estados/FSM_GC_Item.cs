using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_GC_Item : GC_Estado
{
	
	public float timer = 5f;
	public GC_Estado gameplay;
	float c = 0f;

	public override void Entrar (FSM fsm)
	{
		Time.timeScale = 0f;
	}

	public override void Executar (FSM fsm)
	{
		c += Time.unscaledDeltaTime;

		if (c > timer) {
			Encerrar ();
		}
	}

	public override void Sair (FSM fsm)
	{
		Time.timeScale = 1f;
	}

	void Encerrar ()
	{
		Debug.Log ("OK");
		gc.GetComponent<FSM> ().MudarEstado (gameplay);
	}
}
