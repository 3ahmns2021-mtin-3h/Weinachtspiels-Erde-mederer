
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    int countCollisions = 0;

    public TextMeshProUGUI scoreNow;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == "Wasser(Clone)")
        {
            if (countCollisions > 0)
            {
                countCollisions--;
            }
            scoreNow.text = countCollisions.ToString();
            Destroy(collision.gameObject);
            
          

        }
        else if(collision.name == "Schnee(Clone)")  
        {
           
            countCollisions++;
            scoreNow.text = countCollisions.ToString();
            Destroy(collision.gameObject);
        }
        if (countCollisions <= 0)
        {
            countCollisions = 0;
        }
        
    }

    
}
