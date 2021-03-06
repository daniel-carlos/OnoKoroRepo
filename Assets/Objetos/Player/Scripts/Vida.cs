﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour, IDamageble
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

	[Tooltip ("Objeto que será reportado sempre que esta unidade sofrer algum dano\n" +
	"OnDamaga(Damage dano)\nOnDeath()")]
	public GameObject[] listeners;

	[Tooltip ("Objeto que substituirá esse personagem quando morrer.")]
	public GameObject substituto;

	[Tooltip ("Deve-se destruir essse objeto quando morrer?")]
	public bool destruirObjeto = true;
	[Tooltip ("Delay entre a morte e destruir o objeto")]
	public float tempoSobrevida = 0f;

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
		SendMessage ("OnDamage", dano);

		if (hp <= 0) {
			hp = 0;
			Morte ();
			return;
		}

		foreach (GameObject dl in listeners) {
			dl.SendMessage ("OnDamage", dano, SendMessageOptions.DontRequireReceiver);
			if (dl.GetComponent<Animator> () != null) {
				dl.GetComponent<Animator> ().SetTrigger ("dano");
			}
		}
	}

	public void Morte ()
	{
		PlayerEntrada pe = GetComponent<PlayerEntrada> ();
		if (pe != null) {
			//pe.enabled = false;
		}

		foreach (GameObject dl in listeners) {
			dl.SendMessage ("OnDeath", SendMessageOptions.DontRequireReceiver);
		}



		BroadcastMessage ("OnDeath");

		if (substituto != null) {
			GameObject clone = Instantiate (substituto, transform.position, transform.rotation);
		}

		if (destruirObjeto) {
			Destroy (gameObject, tempoSobrevida);
		}
	}
}