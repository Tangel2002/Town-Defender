using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    // Start is called before the first frame update

    float health = 100f;
    const int DAMAGE = 20;
    public GameObject house;

    private void Update()
    {
        if(health <= 0)
        {
            Destroy(house);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bolt")
        {
            Destroy(col.gameObject);
            health = health - DAMAGE;
        }
    }
    
}
