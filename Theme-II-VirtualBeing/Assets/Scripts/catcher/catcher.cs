using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class catcher : MonoBehaviour
{
    [SerializeField] GameObject[] fruits;
    [SerializeField] TextMeshProUGUI timeCount;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject catcherr;

    public float timer;
    public int timeCounter;
    float tim = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer = 2;
        timeCounter = 45;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
        timeCount.text = "Time:" + timeCounter;

            
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            int randFruit = Random.Range(0, fruits.Length);
            Vector2 fruitSpawn = new Vector2(Random.Range(-7, 7), 6);

            Instantiate(fruits[randFruit], fruitSpawn, Quaternion.identity);

            timer = Random.Range(1, 3);
        }

        if(timeCounter == 0)
        {
            mainMenu.SetActive(true);
            catcherr.SetActive(false);
            scoreSystem.score = 0;
            timeCounter = 45;
        }
            
    }

    void Timer()
    {
        tim = tim + Time.deltaTime;
        if(tim >= 1)
        {
            timeCounter--;
            tim = 0;
        }
    }
}
