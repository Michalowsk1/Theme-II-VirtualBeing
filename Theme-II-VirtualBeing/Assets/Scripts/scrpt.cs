using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scrpt : MonoBehaviour
{
    [SerializeField] public static int reward = 0;
    [SerializeField] Rigidbody2D player;
    [SerializeField] GameObject playerObj;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        //playerObj.transform.position = Vector2.zero;
        speed = 7;
        player = GetComponent<Rigidbody2D>();
        //playerObj = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        player.velocity = new Vector2(moveHorizontal * speed, moveVertical * 0);

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.localScale = new Vector2(4, 4);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            player.transform.localScale = new Vector2(-4, 4);
        }
        else if(Input.GetKey(KeyCode.Space))
        {
            //nothing
        }


        if (player.position.x <= -10)
        {
            playerObj.transform.position = new Vector2(10, -2);
        }

        if (player.position.x >= 10)
        {
            playerObj.transform.position = new Vector2(-10, -2);
        }
    }
}
