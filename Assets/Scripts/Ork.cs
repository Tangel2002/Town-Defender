using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ork : MonoBehaviour
{

    public Transform ork;
    public GameObject magik_bolt;
    public Vector3 coords;
    public Vector3 dropoff;
    float cooldown = 5;
    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, -1, 0);
        move *= Time.deltaTime;
        if (ork.position.y >= coords.y)
        {
            ork.Translate(move);
        }

        if(ork.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude == 0)
        {
            cooldown -= 1 * Time.deltaTime;
            if(cooldown <= 0)
            {
                Instantiate(magik_bolt, dropoff, Quaternion.identity);
                cooldown = 5;
            }
        }

    }
}
