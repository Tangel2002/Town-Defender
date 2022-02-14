using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject sword;

    // Update is called once per frame
    void Update()
    {
         if (Input.GetButton("Arrows") && Input.GetAxisRaw("Arrows") < 0)
         {
             sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, sword.transform.eulerAngles.z + 1);
         }
        if (Input.GetButton("Arrows") && Input.GetAxisRaw("Arrows") > 0)
        {
            sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, sword.transform.eulerAngles.z - 1);
        }

    }
}
