using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LossDetection : MonoBehaviour
{

    public GameObject house1;
    public GameObject house2;
    public GameObject house3;

    // Update is called once per frame
    void Update()
    {
        if(house1 == null && house2 == null && house3 == null)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
