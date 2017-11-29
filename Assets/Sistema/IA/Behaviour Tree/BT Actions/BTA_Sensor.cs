using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTA_Sensor : BT_Node
{
	public Transform diagonalA;
	public Transform diagonalB;

	public Collider2D[] contatos;
	public LayerMask layers;

	public Color cor = Color.white;

	public List<Collider2D> objetosIgnorados;
	public string tagT;

	public override IEnumerator Executar ()
	{
		
		foreach (Collider2D cont in contatos) {
			if (ChecarTag (tagT)) {
				state = BT_State.SUCCESS;
				break;
			}
		}
		state = BT_State.FAILURE;
		yield return null;
	}

	public bool ChecarTag (string tagT)
	{
		foreach (Collider2D cont in contatos) {
			if (cont.tag == tagT && !objetosIgnorados.Contains (cont)) {
				return true;
			}
		}
		return false;
	}

	// Update is called once per frame
	void Update ()
	{
		contatos = Physics2D.OverlapAreaAll (diagonalA.position, diagonalB.position, layers);

	}

	void OnDrawGizmos ()
	{
		if (diagonalA != null && diagonalB != null) {
			Vector3 opA = new Vector3 (diagonalA.position.x, diagonalB.position.y, transform.position.z);
			Vector3 opB = new Vector3 (diagonalB.position.x, diagonalA.position.y, transform.position.z);

			Gizmos.color = cor;

			Gizmos.DrawLine (diagonalA.position, diagonalB.position);
			Gizmos.DrawLine (diagonalA.position, opA);
			Gizmos.DrawLine (opA, opB);
			Gizmos.DrawLine (diagonalB.position, opB);
			Gizmos.DrawLine (diagonalB.position, opA);
			Gizmos.DrawLine (diagonalA.position, opB);
		}
	}
}
