using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public GameObject playerPrefab;
	public Transform playerSpawn;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void CriarPlayer ()
	{
		GameObject player = Instantiate (playerPrefab, playerSpawn.position, Quaternion.identity);
	}
}
