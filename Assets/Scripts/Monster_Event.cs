using UnityEngine;
using System.Collections;

public class Monster_Event : MonoBehaviour {
    public int hp = 3;
    public int damage = 1;
    public float speed = 0.01f;
    float m_speed;
    public int attack = 0;
    public int money = 0;
    // Use this for initialization
    void Start () {

        //damage = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        hp -= damage;

        if (other.gameObject.name == "home")
        {
            Destroy(this.gameObject);
        }

        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        transform.Translate(speed,0,0);
        speed += m_speed;
    }
}
