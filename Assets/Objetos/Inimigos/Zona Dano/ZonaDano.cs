using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaDano : MonoBehaviour
{
	public Damage dano;
	public float intervalo = 0.5f;
	public string tags;

	public List<GameObject> alvos = new List<GameObject> ();

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (tags.Contains (col.gameObject.tag)) {
			alvos.Add (col.gameObject);

			col.gameObject.SendMessage ("Damage", dano, SendMessageOptions.DontRequireReceiver);

			StartCoroutine (AplicarDano (col.gameObject));
			Debug.Log ("trigger");
		}
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (tags.Contains (col.gameObject.tag)) {
			alvos.Add (col.gameObject);

			col.gameObject.SendMessage ("Damage", dano, SendMessageOptions.DontRequireReceiver);

			StartCoroutine (AplicarDano (col.gameObject));
			Debug.Log ("collision");
		}
	}

	void OnTriggerExit2D (Collider2D col)
	{
		if (alvos.Contains (col.gameObject)) {
			alvos.Remove (col.gameObject);
			StopCoroutine (AplicarDano (col.gameObject));
		}
	}

	void OnCollisionExit2D (Collision2D col)
	{
		if (alvos.Contains (col.gameObject)) {
			alvos.Remove (col.gameObject);
			StopCoroutine (AplicarDano (col.gameObject));
		}
	}

	IEnumerator AplicarDano (GameObject obj)
	{
		while (alvos.Contains (obj)) {
			yield return new WaitForSeconds (intervalo);
			obj.SendMessage ("Damage", dano, SendMessageOptions.DontRequireReceiver);

		}
	}
}
