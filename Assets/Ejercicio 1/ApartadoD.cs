using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApartadoD : MonoBehaviour
{
    GameObject prefabObstacle;
    // Start is called before the first frame update
    void Start()
    {
        SpawnNObstacles(5);
    }
    void SpawnNObstacles(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Instantiate(prefabObstacle);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
