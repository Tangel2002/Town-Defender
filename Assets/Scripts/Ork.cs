using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ork : MonoBehaviour
{

    public Transform ork;
    public GameObject magik_bolt;
    public Vector3 coords;
    Vector3 dropoff;
    bool done = false;
    float cooldown = 5;

    private void Start()
    {
        coords.x = ork.position.x;
        dropoff = new Vector3(coords.x, coords.y - 1, coords.z);
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, -1, 0);
        move *= Time.deltaTime;
        if (ork.position.y >= coords.y)
        {
            ork.Translate(move);
        }
        else
        {
            done = true;
        }

        if(done)
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
