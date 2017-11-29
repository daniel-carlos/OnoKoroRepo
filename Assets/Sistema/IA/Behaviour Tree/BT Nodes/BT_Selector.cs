using UnityEngine;
using System.Collections;

public class BT_Selector : BT_Node
{
	public override IEnumerator Executar ()
	{
		state = BT_State.RUNNING;
		for (int i = 0; i < transform.childCount; i++) {
			BT_Node nodeFilho = transform.GetChild (i).GetComponent<BT_Node> ();

			nodeFilho.state = BT_State.RUNNING;
			nodeFilho.StartCoroutine (nodeFilho.Executar ());

			while (nodeFilho.state == BT_State.RUNNING) {
				yield return null;
			}

			if (nodeFilho.state == BT_State.SUCCESS) {
				this.state = BT_State.SUCCESS;
				this.StopCoroutine ("Executar");
				break;
			}

		}

		if (this.state != BT_State.SUCCESS) {
			this.state = BT_State.FAILURE;
		}


	}


}
