using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{

	public Transform alvo;
	public float smooth = 1f;
	public Vector3 offset = new Vector3 (0, 0, -10);
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		Vector3 pos = Vector3.Lerp (transform.position, alvo.position, Time.fixedDeltaTime * smooth);
		transform.position = pos + offset;
	}
}
