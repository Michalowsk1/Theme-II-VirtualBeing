using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreSystem : MonoBehaviour
{
    [SerializeField] GameObject player;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "fruit")
        {
            score++;
            
        }

        if (collision.gameObject.tag == "badFruit")
        {
            score -= 3 ;
        }
    }

}
