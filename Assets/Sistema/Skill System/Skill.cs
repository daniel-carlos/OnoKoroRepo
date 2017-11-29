using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : MonoBehaviour
{
	public Skill_Requisito[] requisios;

	//	// Use this for initialization
	//	void Start ()
	//	{
	//		requisios = GetComponents<Skill_Requisito> ();
	//	}

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
		FireSkill ();
		foreach (Skill_Requisito sr in requisios) {
			sr.Sucesso ();
		}

		BroadcastMessage ("OnFireSkill", this, SendMessageOptions.DontRequireReceiver);
	}

	protected abstract void FireSkill ();
}
