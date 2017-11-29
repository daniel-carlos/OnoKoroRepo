using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BT_Debug : MonoBehaviour
{
	public Text texto;
	// Use this for initialization
	void Start ()
	{
		
	}

	public void Configurar ()
	{
		BT_Node nodo = GetComponent<BT_Node> ();

		if (nodo.GetType () == typeof(BT_Selector)) {
			texto.text = "?";
		} else if (nodo.GetType () == typeof(BT_Sequence)) {
			texto.text = ">";
		}
	}

	void Update ()
	{
		SpriteRenderer spr = GetComponent<SpriteRenderer> ();
		if (spr != null) {
			switch (GetComponent<BT_Node> ().state) {
			case BT_State.OFF:
				spr.color = Color.black;
				break;
			case BT_State.SUCCESS:
				spr.color = Color.green;
				break;
			case BT_State.FAILURE:
				spr.color = Color.red;
				break;
			case BT_State.RUNNING:
				spr.color = Color.yellow;
				break;
			}
		}
	}
}
