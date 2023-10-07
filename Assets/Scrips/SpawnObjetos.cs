using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjetos : MonoBehaviour
{
    [SerializeField] GameObject[] obstaculo;
    [SerializeField] public Vector2 PositionSpawn;
    public float StarTime;
    public float repeat;
    private void Start()
    {
        InvokeRepeating("Spawn",4f,2f);
    }
    void Spawn()
    {
        int Randomindex = Random.Range(0, obstaculo.Length);
        GameObject obstaculoaleatorio = obstaculo[Randomindex];
        Instantiate (obstaculoaleatorio, PositionSpawn, obstaculoaleatorio.transform.rotation);
    }
}
