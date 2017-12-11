using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionTree : MonoBehaviour
{
	public float intervalo = 0.1f;
	public bool ativo = true;

	// Use this for initialization
	void Start ()
	{
		//StartCoroutine (UpdateIA ());
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.GetChild (0).SendMessage ("Ativar");
	}

	IEnumerator UpdateIA ()
	{
		while (ativo) {
			transform.GetChild (0).SendMessage ("Ativar");
			yield return new WaitForSeconds (intervalo);
		}
	}
}
