using UnityEngine;
using System.Collections;

public class BT_Repeater : BT_Node
{
	[Tooltip ("0 = infinito")]
	public int repeticoes;

	public override IEnumerator Executar ()
	{
		state = BT_State.RUNNING;
		for (int i = 0; i < repeticoes || repeticoes == 0; i++) {
			transform.GetChild (0).GetComponent<BT_Node> ().Executar ();
		}

		state = BT_State.SUCCESS;
		yield return null;
	}


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

