using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoMenuInicial : MonoBehaviour
{

	public Button botao;
	public GameObject seta;

	//Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void Marcar (bool m)
	{
		seta.SetActive (m);
	}
}
