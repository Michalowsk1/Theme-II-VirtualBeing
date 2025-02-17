using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PurchaseCoat : MonoBehaviour
{
    [SerializeField] GameObject storeCoat;
    [SerializeField] TextMeshProUGUI storeCoatText;
    [SerializeField] GameObject coat;
    // Start is called before the first frame update
    void Start()
    {
        storeCoat.SetActive(true);
        coat.SetActive(false);
    }

    // Update is called once per frame
    public void PurchasedCoat()
    {
        if (scrpt.reward >= 1)
        {
            storeCoat.SetActive(false);
            coat.SetActive(true);
            storeCoatText.text = "Owned";
            scrpt.drip++;
            scrpt.reward--;
        }
    }
}
