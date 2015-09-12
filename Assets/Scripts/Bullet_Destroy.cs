using UnityEngine;
using System.Collections;

public class Bullet_Destroy : MonoBehaviour
{
    Bullet_Move bullet_move;
    public float death = 70f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bullet_move = GetComponent<Bullet_Move>();
        if (bullet_move.speed > death)
        {
            Destroy(gameObject);
        }
    }
}
