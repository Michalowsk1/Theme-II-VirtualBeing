using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PurchaseShoes : MonoBehaviour
{
    [SerializeField] GameObject storeShoe;
    [SerializeField] TextMeshProUGUI storeShoesText;
    [SerializeField] GameObject shoe;
    [SerializeField] GameObject oldShoe;
    // Start is called before the first frame update
    void Start()
    {
        storeShoe.SetActive(true);
        shoe.SetActive(false);
        oldShoe.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PurchasedShoes()
    {
        if (scrpt.reward >= 3)
        {
            storeShoe.SetActive(false);
            shoe.SetActive(true);
            oldShoe.SetActive(false);
            storeShoesText.text = "Owned";
        }
        else { }
    }
}
