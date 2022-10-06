using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalMovement = 0f;
    public float speed = 5f;
    public int left;
    public int right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        //transform.position += new Vector3(horizontalMovement, 0,0) * speed * Time.deltaTime;
        if(horizontalMovement<0)
        {
            if(this.gameObject.transform.position.x > left)
            {
                transform.position += new Vector3(horizontalMovement, 0,0) * speed * Time.deltaTime;
            }
        }
        if(horizontalMovement>0)
        {
            if(this.gameObject.transform.position.x < right)
            {
                transform.position += new Vector3(horizontalMovement, 0,0) * speed * Time.deltaTime;
            }
        }
    }
}
