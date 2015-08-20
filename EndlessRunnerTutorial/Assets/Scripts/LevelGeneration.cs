using UnityEngine;
using System.Collections;

public class LevelGeneration : MonoBehaviour {

	public GameObject[] obstacles;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void CreateObject(int objNum)
	{
		GameObject newObj = Instantiate (obstacles [objNum]);
	}
}
