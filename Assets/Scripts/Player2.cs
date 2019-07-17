using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {	
	
	public float Speed = 1.0f;
	
	void FixedUpdate () {
		
		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.position += Vector3.up * Speed;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.position += Vector3.down * Speed;
		}
	}
}
