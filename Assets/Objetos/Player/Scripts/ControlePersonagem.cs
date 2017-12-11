using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{
	public float speed = 2f;

	public float jump = 5f;

	[SerializeField]
	[Tooltip ("1=direita, -1=Esquerda")]
	private float lookSide = 1f;

	public float LookSide {
		get {
			return lookSide;
		}
		set {
			lookSide = value;
		}
	}


	[Tooltip ("Se a velocidade do personagem deve ser controlada pelo root")]
	public bool rootMotion = false;


	Rigidbody2D rb;
	Animator anim;
	public SensorContato ground;

	private float movimento = 0f;

	public float Movimento {
		get {
			return movimento;
		}
	}

	public bool canMove = true;
	public bool canJump = true;

	private bool grounded = false;

	public bool Grounded {
		get {
			return ground.Grounded;
		}
	}

	//	1 = de pé, 0 = agachado
	float postura = 1f;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		AjustarDirecao ();
		AjustarPostura ();
	}

	void LateUpdate ()
	{
		
	}

	public void AjustarDirecao ()
	{
		Vector3 rot = transform.eulerAngles;
		if (lookSide > 0) {
			rot.y = 0f;
		} else if (lookSide < 0) {
			rot.y = 180f;
		}
		transform.eulerAngles = rot;
	}

	void AjustarPostura ()
	{
		anim.SetFloat ("postura", postura);
	}

	public void Mover (float direcao)
	{
		if (canMove) {
			movimento = Mathf.Abs (Mathf.Clamp (direcao, -1f, 1f));
			if (direcao > 0) {
				lookSide = 1f;
			} else if (direcao < 0) {
				lookSide = -1f;
			} else {
				lookSide = 0f;
			}
		}
	}

	public void Jump (bool force = false)
	{
		
		if (canJump && Grounded || force) {
			Vector2 vel = rb.velocity;
			vel.y = jump;
			rb.velocity = vel;
		}
	}

	void OnAnimatorMove ()
	{

		Vector2 vel = rb.velocity;

		if (!rootMotion) {
			vel.x = movimento * speed * lookSide;
		} else {
			vel.x = anim.velocity.x;
		}

		rb.velocity = vel;
	}

	public void Agachar (bool agachar)
	{
		postura = agachar ? 0f : 1f;
	}


	public void OnDeath ()
	{
		rb.velocity = Vector2.zero;
	}
}
