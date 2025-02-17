using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFlower : MonoBehaviour
{
    [SerializeField] GameObject flower;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Controls.collectCount = Controls.collectCount + 1;
            Destroy(gameObject);
        }
    }
}
