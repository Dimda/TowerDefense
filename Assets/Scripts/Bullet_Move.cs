using UnityEngine;
using System.Collections;

public class Bullet_Move : MonoBehaviour
{
    public float speed = 1f;
    // Use this for initialization
    void Start()
    {
		Invoke ("Summon",1.0f);
    }

	void Summon(){

//		 this.transform.parent = GameObject.Find("Gun(Clone)").transform;
	}

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(speed, 0, 0);
        speed += 1f;
    }
}