using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoEnciclopedia : MonoBehaviour
{
	public EnciclopediaItem[] monstros;
}

[System.Serializable]
public struct EnciclopediaItem
{
	public string nome;
	public Sprite imagem;
	[MultilineAttribute (10)]
	public string conteudo;
}
