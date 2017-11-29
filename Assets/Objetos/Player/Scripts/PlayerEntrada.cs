using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntrada : MonoBehaviour
{
	ControlePersonagem pers;
	public Skill ataqueBasico;
	public Skill dash;
	public Skill doubleJump;
	public Skill shuriken;

	// Use this for initialization
	void Start ()
	{
		pers = GetComponent<ControlePersonagem> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		pers.Mover (Input.GetAxis ("Horizontal"));

		if (pers.Grounded) {
			if (Input.GetButtonDown ("Jump")) {
				pers.Jump ();
			}
		} else {
			if (Input.GetButtonDown ("Jump")) {
				doubleJump.TentarDisparo ();
			}
		}

		if (!Input.GetKey (KeyCode.LeftShift)) {
			if (Input.GetButtonDown ("Fire1")) {
				ataqueBasico.TentarDisparo ();
			}
		} else {
			if (Input.GetButtonDown ("Fire1")) {
				shuriken.TentarDisparo ();
			}
		}

		if (Input.GetButtonDown ("Fire2")) {
			dash.TentarDisparo ();
		}
			
		if (Input.GetAxisRaw ("Vertical") < 0) {
			pers.Agachar (true);
		} else {
			pers.Agachar (false);
		}

	}
}
