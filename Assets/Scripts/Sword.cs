using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sword : MonoBehaviour
{
    public TMP_Text text;
    public GameObject sword;
    public GameObject beam;
    int poweringUp = 1;
    bool on = false;
    float countdown = 3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if(poweringUp >= 1)
            {
                on = true;
                beam.SetActive(true);
            }
        }

        if (on)
        {
            countdown -= 1 * Time.deltaTime;
            if (countdown <= 0)
            {
                on = false;
                beam.SetActive(false);
                countdown = 3;
                poweringUp = 0;
            }
        }


        
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
        text.text = poweringUp.ToString() + " / 10";
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
