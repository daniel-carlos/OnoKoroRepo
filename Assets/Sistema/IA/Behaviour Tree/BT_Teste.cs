using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT_Teste : MonoBehaviour
{
	public BT_Node behaviourTree;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (behaviourTree.state == BT_State.OFF) {
			behaviourTree.StopAllCoroutines ();
			behaviourTree.StartCoroutine ("Executar");
		} else if (behaviourTree.state != BT_State.RUNNING) {
			behaviourTree.state = BT_State.OFF;
		}
	}
}
