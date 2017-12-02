using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
	public GameObject playerHUD;
	public GameObject pauseHUD;
	public GameObject bannerHUD;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void Setup (bool player, bool pause, bool banner)
	{
		playerHUD.SetActive (player);
		pauseHUD.SetActive (pause);
		bannerHUD.SetActive (banner);
	}
}
