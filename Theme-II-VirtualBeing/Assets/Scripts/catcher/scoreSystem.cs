using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreSystem : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] TextMeshProUGUI scoreCount;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount.text = "Score:" + score + "/15";

        if (score == 15)
        {
            SceneManager.LoadScene("MainScene");
            scrpt.reward++;
        }
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
