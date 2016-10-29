using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float smoothing = 5f;
//	private Vector3 offset;

	void Start()
	{
//		offset = transform.position;
	}

	void LateUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		transform.position = transform.position + movement;

		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		//rb.AddForce (movement*speed);
	}




}
