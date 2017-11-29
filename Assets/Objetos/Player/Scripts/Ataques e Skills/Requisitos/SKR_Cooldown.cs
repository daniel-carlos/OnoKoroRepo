using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKR_Cooldown : Skill_Requisito
{
	[SerializeField]
	[Tooltip ("Tempo mínimo entre um udisparo e o pŕoximo")]
	private float cooldown = 1f;

	public float Cooldown {
		get {
			return cooldown;
		}
		set {
			cooldown = value;
		}
	}

	[SerializeField]
	private float last;

	public float Last {
		get {
			return last;
		}
	}

	// Use this for initialization
	void Start ()
	{
		ResetarCooldown ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (last > 0) {
			last -= Time.deltaTime;
		} else {
			last = 0f;
		}
	}

	public void ResetarCooldown ()
	{
		last = cooldown;
	}


	public void ResetarCooldown (float percentual)
	{
		last -= cooldown * percentual / 100f;
	}

	public override bool Passar ()
	{
		return last <= 0;
	}

	public override void Erro ()
	{
		throw new System.NotImplementedException ();
	}

	public override void Sucesso ()
	{
		ResetarCooldown ();
	}
}
