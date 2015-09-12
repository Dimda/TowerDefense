using UnityEngine;
using System.Collections;

public class Bullet_Shot : MonoBehaviour
{
    public GameObject prefab, gun;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab,new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z),this.transform.rotation);
        }
    }
}