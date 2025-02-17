using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    [SerializeField] Rigidbody2D player;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Fuel;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject Parkour;
    [SerializeField] TextMeshProUGUI fuelText;
    [SerializeField] TextMeshProUGUI CollectableText;
    [SerializeField] TextMeshProUGUI playButtonText;
    [SerializeField] Button play;

    public int speed = 4;
    public static int fuelTime;
    public static int Maxfuel;
    public int flightPower = 5;
    public bool fuel = true;
    public static int collectCount;
    // Start is called before the first frame update
    void Start()
    {
        collectCount = 0;
        player = GetComponent<Rigidbody2D>();
        fuelTime = 20;
        Maxfuel = 20;
    }

    // Update is called once per frame
    void Update()
    {
        fuelText.text = fuelTime + "%/" + Maxfuel + "%";
        CollectableText.text = collectCount + "/3 Flowers";


        //MOVEMENT
        player.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.localScale = new Vector2(1, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.localScale = new Vector2(-1, 1);
        }


        //FLIGHT

        if(Input.GetKey(KeyCode.Space) && fuel == true)
        {
            player.velocity = new Vector2(player.velocity.x, flightPower);
            fuelTime--;
        }

        if (fuelTime <= 0)
        {
            fuel = false;
        }

        if(collectCount == 3)
        {
            mainMenu.SetActive(true);
            Parkour.SetActive(false);
            playButtonText.text = "Completed";
            play.enabled = false;
            scrpt.reward++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            fuelTime = Maxfuel;
            fuel = true;
        }
    }
}
