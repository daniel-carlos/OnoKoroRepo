using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTN_Obstaculo : DT_No
{

	public SensorContato sensor;

	// Use this for initialization
	void Start ()
	{
//		if (sensor == null) {
//			sensor = GetComponentInChildren<SensorContato> ();
//		}
	}

	public override void Ativar ()
	{
		SelectChild (sensor.Contato);

	}
}
