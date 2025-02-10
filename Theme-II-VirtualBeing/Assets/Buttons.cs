using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject shoe1;
    [SerializeField] GameObject shoe2;
    [SerializeField] GameObject beanie;
    [SerializeField] GameObject coat;
    // Start is called before the first frame update
    void Start()
    {
        shoe1.SetActive(false);
        shoe2.SetActive(false);
        beanie.SetActive(false);
        coat.SetActive(false);
    }


    public void PurchaseBeanie()
    {
        beanie.SetActive(true);
    }

    public void PurchaseShoes()
    {
        shoe1.SetActive(true);
        shoe2.SetActive(true);
    }

    public void PurchaseCoat()
    {
        coat.SetActive(true);
    }
}
