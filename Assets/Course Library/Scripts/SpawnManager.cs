using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SpawnManager : MonoBehaviour
{
    
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 20;
    public float spawnRangeZ = 20;
    public float spawnPosZ = 20;
    public float spawnPosX = 20;
    private int score;
    public TextMeshProUGUI scoreText;
    
    
    // Start is called before the first frame update
    void SpawnRandomAnimal()
    {
        int rand = Random.Range(1,3);
        if(rand == 1)
        {
            SpawnAnimalTop();
        }else{
            SpawnAnimalSide();
        }

       
    }
    void SpawnAnimalTop()
    {
        var animalIndex = Random.Range(0,animalPrefabs.Length);
        var spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
        Instantiate(animalPrefabs[animalIndex],spawnPos,animalPrefabs[animalIndex].transform.rotation);
        Debug.Log("Spawned Top");
    }
    void SpawnAnimalSide()
    {
        
        int rand = Random.Range(1,3);
        if(rand == 1)
        {
            var animalIndex = Random.Range(0,animalPrefabs.Length);
            var spawnPos = new Vector3(spawnPosX,0,Random.Range(-spawnRangeX,spawnRangeX));
            Instantiate(animalPrefabs[animalIndex],spawnPos,Quaternion.Euler(0, -90, 0));
            Debug.Log("Spawned Left");
        }else{
            var animalIndex = Random.Range(0,animalPrefabs.Length);
            var spawnPos = new Vector3(-spawnPosX,0,Random.Range(-spawnRangeX,spawnRangeX));
            Instantiate(animalPrefabs[animalIndex],spawnPos,Quaternion.Euler(0, 90, 0));
            Debug.Log("Spawned Right");
        }
        
    }
    void Start()
    {

        InvokeRepeating("SpawnRandomAnimal",3.0f,3.0f);
        score = 0;
        scoreText.text = "Score: " + score;
    }
   
    // Update is called once per frame
    void Update()
    {
        
           
            
        
        
    }
    public void UpdateScore(int ScoreToAdd)
    {
        score += ScoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
