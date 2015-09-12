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
		Destroy (gameObject);

		if(GameObject.Find("Build").GetComponent<UnityEngine.UI.Image>().enabled == true)
		{
			GameObject.Find("Build").GetComponent<UnityEngine.UI.Image>().enabled = false;
			GameObject.Find("Text").GetComponent<UnityEngine.UI.Text>().enabled = false;
		}else{
			GameObject.Find("Build").transform.localPosition = new Vector3(Input.mousePosition.x -870, Input.mousePosition.y - 250, 100);
			GameObject.Find("Build").GetComponent<UnityEngine.UI.Image>().enabled = true;
			GameObject.Find("Text").GetComponent<UnityEngine.UI.Text>().enabled = true;
		}

	}
}

