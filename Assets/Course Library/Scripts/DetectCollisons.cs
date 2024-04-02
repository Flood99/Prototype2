using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisons : MonoBehaviour
{   public GameObject spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            var AnimalScript = other.gameObject.GetComponent<MoveForward>();
            var SpawnManager = spawnManager.GetComponent<SpawnManager>();
            SpawnManager.UpdateScore(AnimalScript.score);
            
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        

    }
}
