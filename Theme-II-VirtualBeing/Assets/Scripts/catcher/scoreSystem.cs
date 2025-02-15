using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoreSystem : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] TextMeshProUGUI scoreCount;
    [SerializeField] TextMeshProUGUI PlayButton;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject catcher;
    public Button play;
    public static int score;
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
            catcher.SetActive(false);
            mainMenu.SetActive(true);
            PlayButton.text = "Completed";
            play.enabled = false;
            scrpt.reward++;
        }
        else if(score < 0)
        {
            score = 0;
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
