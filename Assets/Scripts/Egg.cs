using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public int value;
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
            ScoreManager.ScoreSet(value);
            Destroy(this.gameObject);
        }
    }    
}
