using UnityEngine;
using System.Collections;

public class Coletor : MonoBehaviour
{
	public Skill saltoDuplo;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void Coleta (string valor)
	{
		if (valor == "salto duplo") {
			GetComponent<PlayerEntrada> ().doubleJump = saltoDuplo;
			//saltoDuplo.SetActive (true);

		}
	}
}

