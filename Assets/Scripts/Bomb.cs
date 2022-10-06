using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    { 
        if(other.gameObject.tag == "Floor")
        {
            Destroy(this.gameObject);
        }
        
        if(other.gameObject.tag == "Player")
        {
            ScoreManager.score--;
            ScoreManager.count--;
            Destroy(this.gameObject);
        }
    }    
}
