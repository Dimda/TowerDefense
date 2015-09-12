using UnityEngine;
using System.Collections;

public class Bullet_Shot : MonoBehaviour
{
    public GameObject prefab, gun;
	public int destroy_time = 20;
	private int time = 0;
 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (time > destroy_time)
        {
			GameObject bullet    =   (GameObject)Instantiate(prefab,new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z),new Quaternion(0, 180, 0, 0));
			  bullet.transform.parent = this.transform;
			time = 0;
		}

		time ++;  
    }
}