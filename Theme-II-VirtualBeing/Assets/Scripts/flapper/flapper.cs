using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class flapper : MonoBehaviour
{
    [SerializeField] Rigidbody2D Player;
    [SerializeField] GameObject Playerer;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject flappers;
    [SerializeField] TextMeshProUGUI playButtonText;
    public int speed;
    public static float varSpeed;
    public Transform Spawn;
    public Button play;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
        speed = 5;
        varSpeed = 2.5f;
        Player.position = Spawn.position;
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        
        varSpeed = varSpeed + Time.deltaTime/5;

        Player.velocity = new Vector2 (varSpeed, moveVertical * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Death")
        {
            Player.position = Spawn.position;
            varSpeed = 2.5f;
        }

        if (collision.gameObject.tag == "Win")
        {
            mainMenu.SetActive(true);
            flappers.SetActive(false);
            playButtonText.text = "Completed";
            play.enabled = false;
            scrpt.reward++;
        }
    }

    public void QuitButton()
    {
        mainMenu.SetActive(true);
        flappers.SetActive(false);
        varSpeed = 2.5f;
        Player.position = Spawn.position;
    }
}
