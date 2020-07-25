using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVeg : MonoBehaviour
{
    public Transform[] SpawnPoints; //生成一個座標的陣列
    public float spawnTime = 2f; //兩秒生成一次蔬菜
    public GameObject Vegs;

    private void Start()
    {
        InvokeRepeating("SpawnVegs", spawnTime, spawnTime);
    }

    void SpawnVegs()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        Instantiate(Vegs, SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
    }
}
