using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
 
    public Transform target;
    public float speed = 20f;
    public SpriteRenderer flip;
    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(speed*inputX, 0, 0);
        if(move.x < 0)
        {
            flip.flipX = true;
        }
        if(move.x > 0)
        {
            flip.flipX = false;
        }
        move *= Time.deltaTime;
        target.Translate(move);
    }
}
