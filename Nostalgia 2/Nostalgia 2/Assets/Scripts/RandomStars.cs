using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStars : MonoBehaviour
{
    public Vector2 positions;
    void Start()
    {
        transform.position = new Vector2(Random.Range(-positions.x,positions.x),Random.Range(-positions.y,positions.y));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
