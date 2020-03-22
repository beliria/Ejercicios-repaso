using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApartadoB : MonoBehaviour
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

    void SpawnObstacle()
    {
        Instantiate(prefabObstacle);
    }
}
