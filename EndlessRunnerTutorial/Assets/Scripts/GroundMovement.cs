using UnityEngine;
using System.Collections;

public class GroundMovement : MonoBehaviour {

	public float movementSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.back * movementSpeed * Time.deltaTime);
		if(transform.position.z < -10)
		{
			transform.position = new Vector3(0,0,0);
		}
	}
}
