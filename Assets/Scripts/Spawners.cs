using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{


    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject prefab;
    public GameObject prefab2;
    int lastRand = 0;
    float cooldown = 3.5f;
    // Update is called once per frame
    void Update()
    {
        cooldown -= 1*Time.deltaTime;
        if(cooldown <= 0)
        {
            cooldown = 3.5f;
            int rand = Random.Range(1, 6);
            
            if(lastRand == rand)
            {
                while(rand == lastRand)
                {
                    rand = Random.Range(1, 7);
                }

            }
            switch(rand){
                case 1:
                    Instantiate(prefab, spawner1.transform);
                    break;
                case 2:
                    Instantiate(prefab, spawner2.transform);
                    break;
                case 3:
                    Instantiate(prefab, spawner3.transform);
                    break;
                case 4:
                    Instantiate(prefab2, spawner1.transform);
                    break;
                case 5:
                    Instantiate(prefab2, spawner2.transform);
                    break;
                case 6:
                    Instantiate(prefab2, spawner3.transform);
                    break;
            }
            lastRand = rand;
        }
    }
}
