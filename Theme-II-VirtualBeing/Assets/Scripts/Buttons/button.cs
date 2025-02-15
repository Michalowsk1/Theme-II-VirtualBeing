using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject Catcher;
    [SerializeField] GameObject Flapper;
    [SerializeField] GameObject Parkour;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        Catcher.SetActive(false);
        Flapper.SetActive(false);
        Parkour.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void catcherLoad()
    {
        mainMenu.SetActive(false);
        Catcher.SetActive(true);
    }

    public void flapperLoad()
    {
        mainMenu.SetActive(false);
        Flapper.SetActive(true);
    }

    public void parkourLoad()
    {
        mainMenu.SetActive(false);
        Parkour.SetActive(true);
    }
}
