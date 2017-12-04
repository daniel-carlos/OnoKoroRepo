﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
	[SerializeField]
	private int maxHP = 100;

	public int MaxHP {
		get {
			return maxHP;
		}
		set {
			maxHP = value;
		}
	}

	[SerializeField]
	private int hp;

	public int Hp {
		get {
			return hp;
		}
	}

	[Tooltip ("Objeto que será reportado sempre que esta unidade sofrer algum dano")]
	public GameObject[] damageListeners;

	public void ResetHP ()
	{
		hp = maxHP;
	}

	// Use this for initialization
	void Start ()
	{
		ResetHP ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}



	public void Damage (Damage dano)
	{
		hp -= dano.power;
		Debug.Log (dano.power);
		SendMessage ("OnDamage", dano);


		foreach (GameObject dl in damageListeners) {
			dl.SendMessage ("OnDamage", dano, SendMessageOptions.DontRequireReceiver);
			if (dl.GetComponent<Animator> () != null) {
				dl.GetComponent<Animator> ().SetTrigger ("dano");
			}
		}
	}
}

public interface IDamageListener
{
	void OnDamage (Damage dano);
}