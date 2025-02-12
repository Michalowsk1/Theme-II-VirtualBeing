using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitRemove : MonoBehaviour
{
    [SerializeField] GameObject fruit;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
