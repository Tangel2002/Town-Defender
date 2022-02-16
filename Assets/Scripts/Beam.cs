using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bolt" || col.gameObject.tag == "Ork")
        {
            Destroy(col.gameObject);
        }
    }
}
