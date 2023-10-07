using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObstaculo : MonoBehaviour
{
    [SerializeField] private float Speed = 3f;
    [SerializeField] private float LifeTime = 0f;
    [SerializeField] private float MaxLifeTime = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3 (Speed*(Time.deltaTime), 0,0);
        LifeTime += Time.deltaTime;
        if(LifeTime >= MaxLifeTime)
        {
            Destroy(this.gameObject);  
        }
    }
}
