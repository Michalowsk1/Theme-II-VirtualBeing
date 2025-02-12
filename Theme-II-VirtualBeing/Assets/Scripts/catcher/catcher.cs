using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catcher : MonoBehaviour
{
    [SerializeField] GameObject[] fruits;

    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 2;
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
