using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCannister : MonoBehaviour
{
    [SerializeField] GameObject fuel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Controls.Maxfuel = Controls.Maxfuel + 20;
            Controls.fuelTime = Controls.Maxfuel;
            Destroy(gameObject);
        }
    }
}
