using UnityEngine;
using System.Collections;

public class Bullet_Move : MonoBehaviour
{
    public float speed = 1f;
    // Use this for initialization
    void Start()
    {
        this.transform.parent = GameObject.Find("Cube").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(speed, 0, 0);
        speed += 1f;
    }
}