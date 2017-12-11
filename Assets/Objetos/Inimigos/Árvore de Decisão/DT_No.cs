using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DT_No : MonoBehaviour
{
	public abstract void Ativar ();

	//public float tempo = 0.1f;

	public void SelectChild (bool resultado)
	{
		if (resultado) {
			transform.GetChild (0).SendMessage ("Ativar");

		} else {
			transform.GetChild (1).SendMessage ("Ativar");
		}
			

	}
}
