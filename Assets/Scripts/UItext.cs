using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UItext : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}


	private void OnGUI()
	{
		int LifePoint = 100;
		int PowerPoint = 0;

		var r = new Rect (550, 10, 400, 100);
		GUI.Label (r, "Life");
		var rt = new Rect (600, 10, 400, 100);
		GUI.Label (rt, LifePoint.ToString());
		var s = new Rect (550, 40, 400, 100);
		GUI.Label (s, "Power");
		var st = new Rect (600, 40, 400, 100);
		GUI.Label (st, PowerPoint.ToString());
	}
}
