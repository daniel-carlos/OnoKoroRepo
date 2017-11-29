using UnityEngine;
using System.Collections;


public abstract class Skill_Requisito : MonoBehaviour
{
	//Pergunta se esse requisito está sendo satisfeito
	public abstract bool Passar ();

	//Chamado quando esse requisito não for atendido
	public abstract void Erro ();

	//Chamado quando esse um disparo for realizado
	public abstract void Sucesso ();
}

