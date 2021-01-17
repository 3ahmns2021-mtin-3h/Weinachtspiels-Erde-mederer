using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int countCollisions = 0;
    // Start is called before the first frame update
    void Start()

    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("hallo" + collision.name);
        if (collision.name == "Wasser")
        {
            //Debug.Log("-1");
            countCollisions--;
        }
        else if(collision.name == "Schnee")  
        {
            //Debug.Log("+1");
            countCollisions++;
        }
        Debug.Log("count collisions" + countCollisions);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
