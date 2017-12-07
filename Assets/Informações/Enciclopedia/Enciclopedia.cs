using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enciclopedia : MonoBehaviour
{
	public InfoEnciclopedia info;

	[Header ("Lista")]
	public Transform lista;

	[Header ("Card")]
	public Text cardNome;
	public Image cardPreview;
	public Text cardDescricao;

	public int i;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Teste
		ExibirObjeto (i);
		AtualizarLista ();
	}

	void AtualizarLista ()
	{
		int size = info.monstros.Length;

		for (int i = 0; i < lista.childCount; i++) {
			if (i < size) {
				lista.GetChild (i).gameObject.SetActive (true);
				Text t = lista.GetChild (i).GetComponentInChildren<Text> ();
				t.text = info.monstros [i].nome;
			} else {
				lista.GetChild (i).gameObject.SetActive (false);
			}
		}

		lista.GetChild (i).GetComponent<Selectable> ().Select ();
	}

	public void ExibirObjeto (int i)
	{
		cardNome.text = info.monstros [i].nome;
		cardPreview.sprite = info.monstros [i].imagem;
		cardDescricao.text = info.monstros [i].conteudo;
	}

	public void AtualizarCursor (Transform t)
	{
		i = t.GetSiblingIndex ();
	}
}
