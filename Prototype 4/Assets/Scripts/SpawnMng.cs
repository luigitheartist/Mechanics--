using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnMng : MonoBehaviour
{
    public GameObject e_Prefab;
    private float spawnRange=9;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(e_Prefab,new Vector3(0,0,6),e_Prefab.transform.rotation);
        float spawnPosX = Random.Range(-spawnRange, spawnRange); 
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        Instantiate(e_Prefab, randomPos, e_Prefab.transform.rotation);
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
