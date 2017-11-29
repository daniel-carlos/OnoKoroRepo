using UnityEngine;
using System.Collections;
using UnityEditor;

public abstract class BT_Node : MonoBehaviour
{
	public BT_State state;

	public abstract IEnumerator Executar ();

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

public enum BT_State
{
	SUCCESS,
	FAILURE,
	RUNNING,
	OFF
}

public class WaitResponse : CustomYieldInstruction
{
	public override bool keepWaiting {
		get {
			throw new System.NotImplementedException ();
		}
	}
}