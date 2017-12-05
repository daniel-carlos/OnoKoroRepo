using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	[Tooltip ("Prefab do Player que será instanciado")]
	public GameObject player;

	[Tooltip ("Local onde o Player iniciará")]
	public Transform playerSpawn;

	public GameObject bannerPrefab;
	GameObject banner;

	public Canvas canvasPrincipal;
	public GC_Estado estadoMorto;

	// Use this for initialization
	void Start ()
	{
		SetUpCamera ();
		if (canvasPrincipal == null) {
			canvasPrincipal = GameObject.Find ("Canvas").GetComponent<Canvas> ();
		}
	}

	public void SetUpCamera ()
	{
		Transform a = player.transform.Find ("Foco");
		Debug.Log (a);
		Camera.main.GetComponent<CameraTarget> ().alvo = a;
	}

	// Update is called once per frame
	void Update ()
	{
		
	}

	public void CriarBanner ()
	{
		GameObject banner = Instantiate (bannerPrefab);
		this.banner = banner;
		banner.transform.parent = canvasPrincipal.transform;
	}

	public void Configurar (bool showHUD, bool stopTime, bool playerControl)
	{
		player.GetComponent<PlayerEntrada> ().enabled = playerControl;
	}

	public void SairJogo ()
	{
		
	}

	public void ControlarPersonagem (bool controlar)
	{
		player.GetComponent<PlayerEntrada> ().enabled = controlar;
	}


	public void RetornarAoMenu ()
	{
		SceneManager.LoadScene ("Menu Inicial");
	}



	public void OnDeath ()
	{
		GetComponent<FSM> ().MudarEstado (estadoMorto);
	}
}
