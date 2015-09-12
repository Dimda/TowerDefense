using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	private void Update () 
	{
	}
	void OnMouseDown()
	{
		GameObject camera = GameObject.Find("Camera");
		BuildTower tower = camera.GetComponent<BuildTower>();
		tower.coord = gameObject.transform.position;
		tower.name = gameObject.transform.name;

		if (transform.parent.name == "TowersTop") {
			tower.location = "top";
		} else {
			tower.location = "down";
		}

		if(GameObject.Find("Build").GetComponent<UnityEngine.UI.Image>().enabled == false)
		{
			GameObject.Find("Build").GetComponent<UnityEngine.UI.Image>().enabled = true;
			GameObject.Find("Close").GetComponent<UnityEngine.UI.Image>().enabled = true;
			GameObject.Find("CloseText").GetComponent<UnityEngine.UI.Text>().enabled = true;
			GameObject.Find("BuildText").GetComponent<UnityEngine.UI.Text>().enabled = true;
		}
	}
}

