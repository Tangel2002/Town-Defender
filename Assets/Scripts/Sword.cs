using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject sword;
    public GameObject beam;
    int poweringUp = 1;

    // Update is called once per frame
    void Update()
    {
         if (Input.GetButton("Arrows") && Input.GetAxisRaw("Arrows") < 0)
         {
             sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, sword.transform.eulerAngles.z + 0.5f);
         }
        if (Input.GetButton("Arrows") && Input.GetAxisRaw("Arrows") > 0)
        {
            sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, sword.transform.eulerAngles.z - 0.5f);
        }
        if(poweringUp > 10)
        {
            poweringUp = 10;
        }
        beam.transform.localScale = new Vector3(poweringUp, beam.transform.localScale.y, 0);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bolt" || col.gameObject.tag == "Ork")
        {

            Destroy(col.gameObject);
            if(col.gameObject.tag == "Bolt")
            {
                poweringUp++;
            }
        }
    }

}
