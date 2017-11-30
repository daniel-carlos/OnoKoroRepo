using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EfeitoTextoDigitado : MonoBehaviour
{

	Text texto;
	string msg;
	public float intervalo = 0.1f;
	public AudioClip[] sons;

	int cont = 0;
	AudioSource asrc;
	public Animator anim;
	// Use this for initialization
	void Start ()
	{
		texto = GetComponent<Text> ();
		asrc = GetComponent<AudioSource> ();

		//Guardar a mensagem total
		msg = texto.text;

		StartCoroutine (AddCaractere ());
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	IEnumerator AddCaractere ()
	{
		while (cont <= msg.Length) {
			yield return new WaitForSeconds (intervalo);
			texto.text = msg.Substring (0, cont);
			asrc.PlayOneShot (sons [Random.Range (0, sons.Length)]);
			cont++;
		}
		yield return new WaitForSeconds (1);
		if (anim)
			anim.SetTrigger ("fade");
	}
}
