using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour, IDamageListener
{
	public Vida vida;
	public ControlePersonagem personagem;

	public Slider sliderVida;
	public Slider sliderDano;

	public float delay = .5f;
	public float decay = 1f;

	// Use this for initialization
	void Start ()
	{
		sliderVida.maxValue = vida.MaxHP;
		sliderVida.minValue = 0;
		sliderVida.value = vida.MaxHP;

		sliderDano.maxValue = vida.MaxHP;
		sliderDano.minValue = 0;
		sliderDano.value = vida.MaxHP;
	}
	
	// Update is called once per frame
	void Update ()
	{
		sliderVida.maxValue = vida.MaxHP;
		sliderVida.minValue = 0;
		sliderVida.value = vida.Hp;

		sliderDano.maxValue = vida.MaxHP;
		sliderDano.minValue = 0;

		if (vidaAntigo > vida.Hp) {
			OnDamage (new Damage ());
		}

		vidaAntigo = vida.Hp;
	}

	float vidaAntigo = 0;

	public void OnDamage (Damage dano)
	{
		StopCoroutine (AtualizarDano ());
		StartCoroutine (AtualizarDano ());
	}

	IEnumerator AtualizarDano ()
	{
		yield return new WaitForSeconds (delay);
		while (sliderDano.value > sliderVida.value) {
			sliderDano.value = Mathf.Lerp (sliderDano.value, sliderVida.value, decay * Time.deltaTime / (Mathf.Abs (sliderVida.value - sliderDano.value)));
			yield return null;
		}
	}
}
