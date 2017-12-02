using UnityEngine;
using System.Collections;

public class DecisionTree : MonoBehaviour
{
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void Iniciar ()
	{
		transform.GetChild (0).SendMessage ("AtivarDT");
	}
}

