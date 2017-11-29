using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStat
{
	public string name;

	//Valor a ser tomado como base
	public float valorBase;

	//Valor a ser acrescentado ao valor base
	public float flat;

	//Valor percentual a ser adicionado ao status
	public float percent;

	public PlayerStat (string name, float valorBase, float flat, float percent)
	{
		this.name = name;
		this.valorBase = valorBase;
		this.flat = flat;
		this.percent = percent;
	}


	public void Zerar ()
	{
		flat = 0;
		percent = 0;
	}

	public float getValor ()
	{
		return (valorBase + flat) * (1 + percent / 100f);
	}


	public void AplicarModificador (Modificador mod)
	{
		this.flat += mod.valorFlat;
		this.percent += mod.valorPercent;
	}
}
