using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawncasas : MonoBehaviour
{

    [SerializeField] GameObject[] Casas;
    [SerializeField] public Vector2 PositionSpawn;
    public float StarTime;
    public float repeat;
    private void Start()
    {
        InvokeRepeating("Spawn", 1f, 1.2f);
    }
    void Spawn()
    {
        int Randomindex = Random.Range(0, Casas.Length);
        GameObject obstaculoaleatorio = Casas[Randomindex];
        Instantiate(obstaculoaleatorio, PositionSpawn, obstaculoaleatorio.transform.rotation);
    }
}
