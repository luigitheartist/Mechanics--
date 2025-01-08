using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnMng : MonoBehaviour
{
    public GameObject e_Prefab;
    private float spawnRange=9;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        Instantiate(e_Prefab,GenSpawnPos(), e_Prefab.transform.rotation);
        
    }


   
    void Update()
    {
        
    }

    private Vector3 GenSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
