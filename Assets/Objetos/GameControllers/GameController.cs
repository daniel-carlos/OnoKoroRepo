using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	[Tooltip ("Prefab do Player que será instanciado")]
	public GameObject playerPrefab;

	[Tooltip ("Local onde o Player iniciará")]
	public Transform playerSpawn;
	GameObject player;

	public GameObject bannerPrefab;
	GameObject banner;

	public Canvas canvasPrincipal;
	


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
		Camera.main.GetComponent<CameraTarget> ().alvo = player.transform.Find ("Foco");
	}

	// Update is called once per frame
	void Update ()
	{
		
	}

	public void CriarPlayer ()
	{
		GameObject player = Instantiate (playerPrefab, playerSpawn.position, Quaternion.identity);
		this.player = player;
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
}
