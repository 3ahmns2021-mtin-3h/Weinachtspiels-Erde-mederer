using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    int countCollisions = 0;

    public TextMeshProUGUI scoreNow;


    // Start is called before the first frame update
    void Start()

    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("hallo" + collision.name);
        if (collision.name == "Wasser(Clone)")
        {
            Debug.Log("-1");
            countCollisions--;
            scoreNow.text = countCollisions.ToString();
            Destroy(collision.gameObject);
        }
        else if(collision.name == "Schnee(Clone)")  
        {
            Debug.Log("+1");
            countCollisions++;
            scoreNow.text = countCollisions.ToString();
            Destroy(collision.gameObject);
        }
        Debug.Log("count collisions" + countCollisions);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
