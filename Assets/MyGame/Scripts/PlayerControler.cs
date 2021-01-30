using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed ;
    public GameObject player;

    private float moveHorizontal;
    
    // Update is called once per frame
    void Update()
    {
        moveHorizontal= Input.GetAxis("Horizontal") * speed;
        moveHorizontal = moveHorizontal * Time.deltaTime;
        player.GetComponent<Transform>().position = player.GetComponent<Transform>().position + new Vector3(moveHorizontal, 0, 0);
    }
}
    