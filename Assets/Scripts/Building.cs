using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    // Start is called before the first frame update

    float health = 100f;
    const int DAMAGE = 20;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bolt")
        {
            print("a collision has happened");
            Destroy(col.gameObject);
            health = health - DAMAGE;
        }
    }
}
