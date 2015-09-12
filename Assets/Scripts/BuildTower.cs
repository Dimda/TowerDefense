using UnityEngine;
using System.Collections;

public class BuildTower : MonoBehaviour {
	public Vector3 coord;
	public string name;
	public GameObject gun;
	public string location;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void logData()
	{
		GameObject.Find("Build").GetComponent<UnityEngine.UI.Image>().enabled = false;
		GameObject.Find("Close").GetComponent<UnityEngine.UI.Image>().enabled = false;
		GameObject.Find("BuildText").GetComponent<UnityEngine.UI.Text>().enabled = false;
		GameObject.Find("CloseText").GetComponent<UnityEngine.UI.Text>().enabled = false;
		Destroy (GameObject.Find(name));
		if (location == "top") {
			Instantiate (gun, new Vector3 (coord.x, coord.y , coord.z), Quaternion.Euler (0, -90, 0));
		} else {
			Instantiate (gun, new Vector3 (coord.x, coord.y , coord.z), Quaternion.Euler (0, 90, 0));
		}

	}
	public void close()
	{
		GameObject.Find("Build").GetComponent<UnityEngine.UI.Image>().enabled = false;
		GameObject.Find("Close").GetComponent<UnityEngine.UI.Image>().enabled = false;
		GameObject.Find("CloseText").GetComponent<UnityEngine.UI.Text>().enabled = false;
		GameObject.Find("BuildText").GetComponent<UnityEngine.UI.Text>().enabled = false;
	}
}
