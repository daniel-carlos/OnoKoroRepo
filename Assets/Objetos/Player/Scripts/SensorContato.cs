using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorContato : MonoBehaviour
{
	public bool grounded;

	public bool Grounded {
		get {
			return grounded;
		}
	}

	[Tooltip ("Envia a mensagem OnAterrissagem quando aterrissa")]
	public bool reportarInicioToque;

	public string tags;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnTriggerStay2D (Collider2D col)
	{
		if (!grounded && reportarInicioToque) {
			transform.root.BroadcastMessage ("OnAterrissagem", SendMessageOptions.DontRequireReceiver);
		}

		if (tags.Contains (col.tag)) {
			grounded = true;
		}


	}

	void OnTriggerExit2D (Collider2D col)
	{
		if (tags.Contains (col.tag)) {
			grounded = false;
		}
	}
}
