using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesSystem : MonoBehaviour
{
    public TextMeshProUGUI livesText;
    private int life = 3;
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: "+ life;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            UpdateLife(-1);
            livesText.text = "Lives: " + life;
            Destroy(other.gameObject);
                    
        }

    }
    void UpdateLife(int ChangeInLife)
    {
        life += ChangeInLife;
        if(life <= 0)
        {
            Debug.Log("You Lose");
        }
    }
}
