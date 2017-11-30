using System.Collections;
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
	public GameObject damageListener;

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



	public virtual void Damage (Damage dano)
	{
		hp -= dano.power;
		if (damageListener) {
			damageListener.SendMessage ("OnDamage", dano.power);
		}
	}
}
