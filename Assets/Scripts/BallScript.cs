using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallScript : MonoBehaviour {

	public GameController gamecontroller;

	public GameObject StartText;

	public bool isMoving = false;

	public float XSpeed = 1.0f;
	public float YSpeed = 1.0f;	

	void FixedUpdate () {
		if (isMoving == false) 
		{
			this.gameObject.transform.position = new Vector3(0,0,0);
			StartText.SetActive(true);

			if (Input.GetKeyDown (KeyCode.Space) && gamecontroller.GameOver == false)
			{
				isMoving = true;
				StartText.SetActive(false);
			}
		}
		if (isMoving == true)
		{
			this.gameObject.transform.Translate(new Vector3(XSpeed,YSpeed,0.0f));
		}
	}

	
	void OnTriggerEnter2D (Collider2D coll){
			
		if (coll.gameObject.tag == "Player")
		{
			XSpeed *= -1.0f;
			YSpeed *= 1.0f;
			XSpeed += 0.01f;
			YSpeed += 0.01f;
		}
		if (coll.gameObject.tag == "Right Wall")
		{
			isMoving = false;
			gamecontroller.Player1Score += 1;
		}
		if (coll.gameObject.tag == "Left Wall")
		{
			isMoving = false;
			gamecontroller.Player2Score += 1;
		}
		if (coll.gameObject.tag == "Top Wall" || coll.gameObject.tag == "Bottom Wall")
		{
			YSpeed *= -1.0f;
		}
	}
}
