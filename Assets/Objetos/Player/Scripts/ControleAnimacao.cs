using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleAnimacao : MonoBehaviour
{
	Animator anim;
	ControlePersonagem pers;

	[Tooltip ("Nome das animações que controlarão o RootMotion")]
	public string[] estadosRoot;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
		pers = GetComponent<ControlePersonagem> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		anim.SetFloat ("vel", pers.Movimento * 2);
		anim.SetBool ("ground", pers.Grounded);

		bool root = false;
		foreach (string str in estadosRoot) {
			if (anim.GetCurrentAnimatorClipInfo (0) [0].clip.name == str) {
				root = true;
				break;
			}
		}
		pers.rootMotion = root;
	}

}
