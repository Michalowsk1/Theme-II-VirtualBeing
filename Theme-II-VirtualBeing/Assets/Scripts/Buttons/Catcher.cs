using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Catcher : MonoBehaviour
{
    public Button play;
    public void catcherLoad()
    {
        SceneManager.LoadScene("Catcher");
    }
}
