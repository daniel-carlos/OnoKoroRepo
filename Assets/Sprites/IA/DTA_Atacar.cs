using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTA_Atacar : DT_No
{

	public Skill skillAtaque;
	public string mensagem;

	public override void Ativar ()
	{
		skillAtaque.TentarDisparo ();
		Debug.Log ("ok");
	}


	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
