using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			transform.GetComponent<Animation>().Play("flip");
			transform.GetComponent<Animation>().PlayQueued("run");
		}
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			transform.GetComponent<Animation>().Play("death");
			transform.GetComponent<Animation>().PlayQueued("run");
		}
	}
}
