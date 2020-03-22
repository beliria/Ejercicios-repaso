using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApartadoC : MonoBehaviour
{
    GameObject prefabObstacle;
    // Start is called before the first frame update
    void Start()
    {
        int x = 5;
        int y = 3;
        Vector2 Position = new Vector2(x, y);
        SpawnObstacleIn(Position);
    }
    void SpawnObstacleIn(Vector2 position)
    {
        Instantiate(prefabObstacle, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
