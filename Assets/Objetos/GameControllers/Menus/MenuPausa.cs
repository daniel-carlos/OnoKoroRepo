using UnityEngine;
using System.Collections;

public class MenuPausa : MonoBehaviour
{
	public GC_Estado estadoNormal;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void SairPausa (FSM fsm)
	{
		fsm.MudarEstado (estadoNormal);
	}

}

