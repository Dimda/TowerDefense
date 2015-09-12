using UnityEngine;
using System.Collections;

public class BuildTower : MonoBehaviour {
	public Vector3 coord;
	public string name;
	public GameObject gun;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void logData()
	{
		Destroy (GameObject.Find(name));
		Instantiate( gun, new Vector3 (coord.x,coord.y,coord.z), this.transform.rotation);
	}
}
