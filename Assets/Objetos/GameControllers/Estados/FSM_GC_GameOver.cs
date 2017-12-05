using UnityEngine;
using System.Collections;

public class FSM_GC_GameOver : GC_Estado
{
	public GameObject menuGO;

	public override void Entrar (FSM fsm)
	{
		menuGO.SetActive (true);
		//menuGO.GetComponent<Animator>()
	}

	public override void Executar (FSM fsm)
	{
		
	}

	public override void Sair (FSM fsm)
	{
		
	}
}

