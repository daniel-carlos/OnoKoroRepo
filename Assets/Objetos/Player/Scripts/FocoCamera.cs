using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocoCamera : MonoBehaviour
{
	Rigidbody2D rb;
	public Transform foco;
	public Transform focoAlto;
	public Transform focoBaixo;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		foco.position = Vector3.Lerp (focoAlto.position, focoBaixo.position, -rb.velocity.y + 0.5f);
	}
}
