using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOOPFLOOR : MonoBehaviour
{
    public float positionx = 19;
    public float positiony = -4.72f;
    private float speed = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(speed * (Time.deltaTime), 0, 0);
        if(transform.position.x <= -(positionx))
        {
            transform.position = new Vector3(positionx, positiony, 0);
        }
    }
}
