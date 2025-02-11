using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrpt : MonoBehaviour
{
    [SerializeField] Rigidbody2D player;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        player.velocity = new Vector2(moveHorizontal * speed, moveVertical * 0);

        if(Input.GetKey("D")
            {
                
            }
    }
}
