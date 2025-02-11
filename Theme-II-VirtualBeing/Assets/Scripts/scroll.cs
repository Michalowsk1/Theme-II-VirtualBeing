using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    public float speed;

    [SerializeField] private Renderer renderers;

    private void Update()
    {
        renderers.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
    //Ref:https://www.youtube.com/watch?v=Wz3nbQPYwss
}
