using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;
    // Start is called before the first frame update
     void SpawnRandomAnimal()
    {
        var animalIndex = Random.Range(0,animalPrefabs.Length);
        var spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
         Instantiate(animalPrefabs[animalIndex],spawnPos,animalPrefabs[animalIndex].transform.rotation);
    }
    void Start()
    {

        InvokeRepeating("SpawnRandomAnimal",3.0f,3.0f);
    }
   
    // Update is called once per frame
    void Update()
    {
        
           
            
        
        
    }
}
