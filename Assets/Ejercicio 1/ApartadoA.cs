using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApartadoA: MonoBehaviour
{
    GameObject prefabObstacle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject SpawnObstacle()
    {
        GameObject obstacle = Instantiate(prefabObstacle);
        return obstacle;
    }
}
