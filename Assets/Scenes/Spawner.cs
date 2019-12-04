using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    Numofenemies myClass;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        myClass = FindObjectOfType<Numofenemies>();
        GameObject copy = Instantiate(enemy, transform.position, Quaternion.identity) as GameObject;
        if (myClass)
            myClass.numofenemies++;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
