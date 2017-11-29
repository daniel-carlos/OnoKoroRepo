using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuInicial : MonoBehaviour
{
	public Selectable botaoPadrao;
	public string cenaInicio;

	public void IniciarLevel (string cena)
	{
		SceneManager.LoadScene (cena);
	}

	public void Inicio ()
	{
		SceneManager.LoadScene (cenaInicio);
	}

	// Use this for initialization
	void Start ()
	{
		//botaoPadrao.Select ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
