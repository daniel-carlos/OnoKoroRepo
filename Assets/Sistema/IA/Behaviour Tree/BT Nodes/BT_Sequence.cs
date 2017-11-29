using UnityEngine;
using System.Collections;

public class BT_Sequence : BT_Node
{
	public override IEnumerator Executar ()
	{
		state = BT_State.RUNNING;
		for (int i = 0; i < transform.childCount; i++) {
			BT_Node node = transform.GetChild (i).GetComponent<BT_Node> ();

			node.state = BT_State.RUNNING;
			node.StartCoroutine ("Executar");

			while (node.state == BT_State.RUNNING) {
				yield return null;
			}

			if (node.state == BT_State.FAILURE) {
				this.state = BT_State.FAILURE;
				this.StopCoroutine ("Executar");
				break;
			}

		}

		if (this.state != BT_State.FAILURE) {
			this.state = BT_State.SUCCESS;
		}
	}
}
