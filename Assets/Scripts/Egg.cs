using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {  
        if(other.gameObject.tag == "Floor")
        {
            ScoreManager.score--;
            ScoreManager.count--;
            Destroy(this.gameObject);
        }
        
        if(other.gameObject.tag == "Player")
        {
            ScoreManager.score++;
            Destroy(this.gameObject);
        }
    }    
}
