using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	Animation animation;
	public float speed;

	// Use this for initialization
	void Start () {
		animation = transform.GetComponent<Animation> ();
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
			StartCoroutine("Slide");
		}
	}
	IEnumerator Slide()
	{
		transform.GetComponent<Animation>().Play("death");
		while (animation["death"].normalizedTime >= 0)
		{
			if(animation["death"].normalizedTime > 2)
			{
				animation.Stop();
				transform.GetComponent<Animation>().PlayQueued("run");
				StopCoroutine("Slide");
			}
			yield return null;
		}
		yield return null;
	}
}
