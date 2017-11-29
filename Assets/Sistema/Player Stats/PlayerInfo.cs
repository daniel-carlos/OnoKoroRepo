using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
	public PlayerStat[] stats;


	[ContextMenu ("Gerar Valor Real")]
	public void mostrarValor ()
	{
		string resp = "";
		foreach (PlayerStat st in stats) {
			resp += st.name + " " + st.getValor () + "\t";
		}
		Debug.Log (resp);
	}

	public PlayerStat GetValor (string nome)
	{
		foreach (PlayerStat st in stats) {
			if (st.name == nome)
				return st;
		}
		return null;
	}

	public void AtualizarValores ()
	{
		//Zera todos os modificadores
		foreach (PlayerStat st in stats) {
			st.Zerar ();
		}


		foreach (Modificador mod in GetComponentsInChildren<Modificador>()) {
			foreach (PlayerStat st in stats) {
				if (mod.nome == st.name) {
					st.AplicarModificador (mod);
				}
			}
		}
	}

	// Use this for initialization
	void Start ()
	{
		AtualizarValores ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		AtualizarValores ();
	}
}
