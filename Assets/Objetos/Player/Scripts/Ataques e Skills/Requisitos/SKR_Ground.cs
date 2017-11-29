using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKR_Ground : Skill_Requisito
{

	public SensorContato sensor;
	public bool inverter = false;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public override bool Passar ()
	{
		return inverter ? !sensor.Grounded : sensor.Grounded;
	}

	public override void Erro ()
	{
		throw new System.NotImplementedException ();
	}

	public override void Sucesso ()
	{
		throw new System.NotImplementedException ();
	}
}
