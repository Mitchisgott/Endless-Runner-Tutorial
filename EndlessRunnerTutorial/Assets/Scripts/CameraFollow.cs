using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float followDistance;

	private GameObject player;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update () {
		transform.position = new Vector3 (0, 2, player.transform.position.z - followDistance);
	}
}
