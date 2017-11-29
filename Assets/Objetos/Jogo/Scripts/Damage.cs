using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Damage
{
	public GameObject owner;
	public int power;
	public string info;

	public Damage (GameObject owner, int damage, string info)
	{
		this.owner = owner;
		this.power = damage;
		this.info = info;
	}
	
}
