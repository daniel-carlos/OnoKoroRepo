using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM : MonoBehaviour
{

	public FSM_Estado estadoAtual;


	public void MudarEstado (FSM_Estado novo)
	{
		if (estadoAtual != null) {
			estadoAtual.Sair (this);
		}

		if (novo != null) {
			estadoAtual = novo;
			estadoAtual.Entrar (this);
		}
	}

	// Use this for initialization
	void Start ()
	{
		if (estadoAtual != null) {
			estadoAtual.Entrar (this);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (estadoAtual != null) {
			estadoAtual.Executar (this);
		}
	}
}
