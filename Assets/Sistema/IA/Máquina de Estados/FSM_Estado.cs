using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FSM_Estado : MonoBehaviour
{

	public abstract void Entrar (FSM fsm);

	public abstract void Executar (FSM fsm);

	public abstract void Sair (FSM fsm);
}
