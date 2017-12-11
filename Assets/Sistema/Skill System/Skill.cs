using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
	public Skill_Requisito[] requisios;
	public Skill_Disparador[] disparadores;

	// Use this for initialization
	void Start ()
	{
		requisios = GetComponents<Skill_Requisito> ();
		disparadores = GetComponents<Skill_Disparador> ();
	}

	public void TentarDisparo ()
	{
		bool canFire = true;

		foreach (Skill_Requisito sr in requisios) {
			if (!sr.Passar ()) {
				canFire = false;
				sr.Erro ();
			}
		}

		if (canFire) {
			Disparar ();
		}
	}

	void Disparar ()
	{
		foreach (Skill_Disparador dis in disparadores) {
			dis.FireSkill ();
		}

		foreach (Skill_Requisito sr in requisios) {
			sr.Sucesso ();
		}

		BroadcastMessage ("OnFireSkill", this, SendMessageOptions.DontRequireReceiver);
	}
}
