using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public int value;
    void OnCollisionEnter(Collision other)
    { 
        if(other.gameObject.tag == "Floor")
        {
            Destroy(this.gameObject);
        }
        
        if(other.gameObject.tag == "Player")
        {
            ScoreManager.count++;
            ScoreManager.ScoreSet(value);
            Destroy(this.gameObject);
        }
    }
}
