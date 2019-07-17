using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {	

	public float Speed = 1.0f;

	void FixedUpdate () {

		if (Input.GetKey(KeyCode.W))
		{
			this.transform.position += Vector3.up * Speed;
		}
		if (Input.GetKey(KeyCode.S))
		{
			this.transform.position += Vector3.down * Speed;
		}
	}
}
